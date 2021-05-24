using ModelTool.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTool.Core
{
    static class Utility
    {
        private static SqlConnection GetConnection(string conStr)
        {
            return new SqlConnection(conStr);
        }

        public static List<string> GetDatabases(string constr)
        {
            using (var con = GetConnection(constr))
            {
                con.Open();

                var getDatabaseStr = "SELECT name FROM Master..SysDatabases ORDER BY name";

#if DEBUG
                Console.WriteLine(getDatabaseStr);
#endif

                using (var cmd = new SqlCommand(getDatabaseStr, con))
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
        }

        public static List<string> GetTables(string constr, string database)
        {
            using (var con = GetConnection(constr))
            {
                con.Open();

                var getTableStr = $"SELECT name FROM {database}..SysObjects WHERE XType='U' ORDER BY name";

#if DEBUG
                Console.WriteLine(getTableStr);
#endif

                using (var cmd = new SqlCommand(getTableStr, con))
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
        }

        public static List<ColumnInfo> GetColumns(string constr, string database, string table)
        {
            using (var con = GetConnection(constr))
            {
                con.Open();

                var getColumnStr = $@"SELECT sc.name,sty.name,sc.is_nullable,ISNULL(sep.value,'') FROM {database}.sys.columns sc 
LEFT JOIN {database}.sys.tables st ON sc.object_id = st.object_id
LEFT JOIN {database}.sys.types sty ON sc.system_type_id = sty.system_type_id
LEFT JOIN {database}.sys.extended_properties sep ON sep.major_id = st.object_id AND sep.minor_id = sc.column_id
WHERE st.name = '{table}'";

#if DEBUG
                Console.WriteLine(getColumnStr);
#endif

                using (var cmd = new SqlCommand(getColumnStr, con))
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
        }
    }
}
