using ModelTool.Model;
using ModelTool_CSharp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTool_CSharp.Core.Generator.Sql
{
    class MSSQLServerGenerator : SqlGenerator<SqlConnection>
    {
        MSSQLServerGenerator(SqlGeneratorSetting setting) : base(setting) { }

        public override SqlConnection GetConnection()
        {
            return new SqlConnection($"Server={Setting.ServerAddress};Uid={Setting.UserAccount};Pwd={Setting.UserPassword}");
        }

        public override List<string> GetDatabases()
        {
            try
            {
                Connection.Open();

                var getDatabaseStr = "SELECT name FROM Master..SysDatabases ORDER BY name";

#if DEBUG
                Console.WriteLine(getDatabaseStr);
#endif

                using (var cmd = new SqlCommand(getDatabaseStr, Connection))
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

        public override List<string> GetTables(string database)
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
        public override List<ColumnInfo> GetColumns(string database, string table)
        {
            try
            {
                Connection.Open();

                var getColumnStr = $@"SELECT sc.name,sty.name,sc.is_nullable,ISNULL(sep.value,'') FROM {database}.sys.columns sc 
LEFT JOIN {database}.sys.tables st ON sc.object_id = st.object_id
LEFT JOIN {database}.sys.types sty ON sc.system_type_id = sty.system_type_id
LEFT JOIN {database}.sys.extended_properties sep ON sep.major_id = st.object_id AND sep.minor_id = sc.column_id
WHERE st.name = '{table}'";

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
                            IsNullable = reader.GetBoolean(2),
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
    }
}
