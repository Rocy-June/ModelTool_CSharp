using ModelTool.Core.Generator.Sql.Interface;
using ModelTool.Core.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTool.Core.Generator.Sql.Base
{
    class MSSQLServerGenerator : ISqlGenerator
    {
        public SqlGeneratorSetting Setting { get; }

        private SqlConnection Connection { get; set; }

        public const string DEFAULT_INSTANCE_NAME = "MSSQLSERVER";

        public MSSQLServerGenerator(SqlGeneratorSetting setting)
        {
            Setting = setting;
        }

        public bool TryGetConnection(out string message)
        {
            try
            {
                var instanceName = Setting.SqlInstanceName == DEFAULT_INSTANCE_NAME
                    ? string.Empty
                    : $@"\{Setting.SqlInstanceName}";

                Connection = new SqlConnection($"Server={Setting.ServerAddress}{instanceName};Uid={Setting.UserAccount};Pwd={Setting.UserPassword}");
                Connection.Open();

                message = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
#if DEBUG
                Console.WriteLine($@"{ex.Message}
{ex.StackTrace}");
#endif
                Connection = null;
                return false;
            }

        }

        public List<string> GetDatabases()
        {
            var getDatabaseStr = "SELECT name FROM Master..SysDatabases ORDER BY name";

#if DEBUG
            Console.WriteLine(getDatabaseStr);
#endif

            using (var cmd = new SqlCommand(getDatabaseStr, Connection))
            using (var reader = cmd.ExecuteReader())
            {
                var databaseList = new List<string>();
                while (reader.Read())
                {
                    databaseList.Add(reader.GetString(0));
                }

                return databaseList;
            }
        }

        public List<string> GetTables(string database)
        {
            var getTableStr = $"SELECT name FROM [{database}]..SysObjects WHERE XType='U' ORDER BY name";

#if DEBUG
            Console.WriteLine(getTableStr);
#endif

            using (var cmd = new SqlCommand(getTableStr, Connection))
            using (var reader = cmd.ExecuteReader())
            {
                var tableList = new List<string>();
                while (reader.Read())
                {
                    tableList.Add(reader.GetString(0));
                }

                return tableList;
            }
        }
        public List<ColumnInfo> GetColumns(string database, string table)
        {
            var getColumnStr = $@"
SELECT 
	sc.name,
	sty.name type,
	sc.is_nullable, 
	(SELECT COUNT(*) FROM [{database}].sys.identity_columns sic
	WHERE sc.object_id = sic.object_id AND sc.column_id = sic.column_id) is_identity,
	ISNULL(sep.value, '') description
FROM [{database}].sys.columns sc
LEFT JOIN [{database}].sys.tables sta ON sc.object_id = sta.object_id
LEFT JOIN [{database}].sys.types sty ON sc.user_type_id = sty.user_type_id
LEFT JOIN [{database}].sys.extended_properties sep ON sc.object_id = sep.major_id AND sc.column_id = sep.minor_id
WHERE sta.name = '{table}'
ORDER BY sc.column_id";

#if DEBUG
            Console.WriteLine(getColumnStr);
#endif

            using (var cmd = new SqlCommand(getColumnStr, Connection))
            using (var reader = cmd.ExecuteReader())
            {
                var columnList = new List<ColumnInfo>();
                while (reader.Read())
                {
                    columnList.Add(new ColumnInfo()
                    {
                        Name = reader.GetString(0),
                        Type = reader.GetString(1),
                        IsNullable = reader.GetBoolean(2),
                        IsPrimaryKey = reader.GetInt32(3) == 1,
                        IsIdentity = reader.GetInt32(3) == 1,
                        Summary = reader.GetString(4),
                    });
                }

                return columnList;
            }
        }

        public void Dispose()
        {
            Connection?.Dispose();
        }

        /* 
         
Completed Table Query SQL 
        
SELECT
    [TableName]		=	CASE WHEN sc.colorder = 1 THEN so.name ELSE '' END,
    [TableExplain]	=	CASE WHEN sc.colorder = 1 THEN ISNULL(sep_te.value, '') ELSE '' END,
    [FieldNumber]	=	sc.colorder,
    [FieldName]		=	sc.name,
    [IsIdentity]	=	CASE WHEN COLUMNPROPERTY(sc.id,sc.name, 'IsIdentity') = 1 THEN '√' ELSE '' END,
    [PrimaryKey]	=	CASE WHEN EXISTS (
							SELECT 1 FROM sysobjects
							WHERE xtype = 'PK'
								AND parent_obj = sc.id 
								AND name IN (
									SELECT name FROM sysindexes
									WHERE indid IN (
										SELECT indid FROM sysindexkeys
										WHERE id = sc.id 
										AND colid = sc.colid
									)
								)
						) THEN '√' ELSE '' END,
    [Type]			=	st.name,
    [OccupySize]	=	sc.length,
    [Length]		=	COLUMNPROPERTY(sc.id, sc.name, 'PRECISION'),
    [Scale]			=	ISNULL(COLUMNPROPERTY(sc.id, sc.name, 'Scale'),0),
    [AllowNull]		=	CASE WHEN sc.isnullable = 1 THEN '√' ELSE '' END,
    [Default]		=	ISNULL(scm.text, ''),
    [FieldExplain]	=	ISNULL(sep_fe.value, '')
FROM syscolumns sc
LEFT JOIN systypes st ON sc.xusertype = st.xusertype
INNER JOIN sysobjects so ON sc.id = so.id AND so.xtype='U' AND so.name <> 'dtproperties'
LEFT JOIN syscomments scm ON sc.cdefault = scm.id
LEFT JOIN sys.extended_properties sep_fe ON sc.id = sep_fe.major_id AND sc.colid = sep_fe.minor_id
LEFT JOIN sys.extended_properties sep_te ON so.id = sep_te.major_id AND sep_te.minor_id = 0
WHERE so.name = 'TR_BD_DrugsData'
ORDER BY sc.id, sc.colorder
         
         */
    }
}
