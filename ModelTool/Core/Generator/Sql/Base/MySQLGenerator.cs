using ModelTool.Core.Generator.Sql.Interface;
using ModelTool.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTool.Core.Generator.Sql.Base
{
    class MySQLGenerator : ISqlGenerator
    {
        public SqlGeneratorSetting Setting { get; }

        private SqlConnection Connection { get; }

        public MySQLGenerator(SqlGeneratorSetting setting) 
        {
            Setting = setting;
            Connection = GetConnection() as SqlConnection;
        }

        public DbConnection GetConnection()
        {
            return new SqlConnection($"Server={Setting.ServerAddress};Uid={Setting.UserAccount};Pwd={Setting.UserPassword}");
        }

        public List<string> GetDatabases()
        {
            try
            {
                Connection.Open();

                var getDatabaseStr = "SELECT name FROM Master..SysDatabases ORDER BY name";

#if DEBUG
                Console.WriteLine(getDatabaseStr);
#endif

                using (var cmd = new SqlCommand(getDatabaseStr, Connection as SqlConnection))
                {
                    var reader = cmd.ExecuteReader();

                    var databaseList = new List<string>();
                    while (reader.Read())
                    {
                        databaseList.Add(reader.GetString(0));
                    }

                    return databaseList;
                }
            }
            finally
            {
                Connection.Close();
            }
        }

        public List<string> GetTables(string database)
        {
            try
            {
                Connection.Open();

                var getTableStr = $"SELECT name FROM {database}..SysObjects WHERE XType='U' ORDER BY name";

#if DEBUG
                Console.WriteLine(getTableStr);
#endif

                using (var cmd = new SqlCommand(getTableStr, Connection))
                {
                    var reader = cmd.ExecuteReader();

                    var tableList = new List<string>();
                    while (reader.Read())
                    {
                        tableList.Add(reader.GetString(0));
                    }

                    return tableList;
                }
            }
            finally
            {
                Connection.Close();
            }
        }
        public List<ColumnInfo> GetColumns(string database, string table)
        {
            try
            {
                Connection.Open();

                var getColumnStr = $@"SELECT sc.name, st.name, sc.isnullable, sep.value
FROM {database}.sys.syscolumns sc
LEFT JOIN {database}.sys.systypes st ON sc.xusertype = st.xusertype
INNER JOIN {database}.sys.sysobjects so ON sc.id = so.id AND so.xtype = 'U' AND so.name <> 'dtproperties'
LEFT JOIN {database}.sys.extended_properties sep ON sc.id = sep.major_id AND sc.colid = sep.minor_id
WHERE so.name = '{table}'";

#if DEBUG
                Console.WriteLine(getColumnStr);
#endif

                using (var cmd = new SqlCommand(getColumnStr, Connection))
                {
                    var reader = cmd.ExecuteReader();

                    var columnList = new List<ColumnInfo>();
                    while (reader.Read())
                    {
                        columnList.Add(new ColumnInfo()
                        {
                            Summary = reader.GetString(3),
                            Type = reader.GetString(1),
                            IsNullable = reader.GetInt32(2) == 1,
                            Name = reader.GetString(0)
                        });
                    }

                    return columnList;
                }

            }
            finally
            {
                Connection.Close();
            }
        }

        public void Dispose()
        {
            Connection.Dispose();
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
