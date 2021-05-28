using ModelTool.Core.Generator.Sql.Interface;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ModelTool.Core.Model;

namespace ModelTool.Core.Generator.Sql.Base
{
    class MySQLGenerator : ISqlGenerator
    {
        public SqlGeneratorSetting Setting { get; }

        private MySqlConnection Connection { get; set; }

        private const string IS_NULLABLE_YES = "YES";

        public MySQLGenerator(SqlGeneratorSetting setting)
        {
            Setting = setting;
        }

        public bool TryGetConnection(out string message)
        {
            try
            {
                Connection = new MySqlConnection($"Server={Setting.ServerAddress};Uid={Setting.UserAccount};Pwd={Setting.UserPassword}");
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
            var getDatabaseStr = "SELECT SCHEMA_NAME FROM information_schema.SCHEMATA";

#if DEBUG
            Console.WriteLine(getDatabaseStr);
#endif

            using (var cmd = new MySqlCommand(getDatabaseStr, Connection))
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

        public List<string> GetTables(string database)
        {
            var getTableStr = $"SELECT TABLE_NAME FROM information_schema.TABLES WHERE TABLE_SCHEMA = '{database}'";

#if DEBUG
            Console.WriteLine(getTableStr);
#endif

            using (var cmd = new MySqlCommand(getTableStr, Connection))
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
        public List<ColumnInfo> GetColumns(string database, string table)
        {
            var getColumnStr = $@"SELECT COLUMN_NAME, DATA_TYPE, IS_NULLABLE, COLUMN_COMMENT
FROM information_schema.COLUMNS
WHERE TABLE_SCHEMA = '{database}'
AND TABLE_NAME = '{table}'";

#if DEBUG
            Console.WriteLine(getColumnStr);
#endif

            using (var cmd = new MySqlCommand(getColumnStr, Connection))
            {
                var reader = cmd.ExecuteReader();

                var columnList = new List<ColumnInfo>();
                while (reader.Read())
                {
                    columnList.Add(new ColumnInfo()
                    {
                        Summary = reader.GetString(3),
                        Type = reader.GetString(1),
                        IsNullable = reader.GetString(2) == IS_NULLABLE_YES,
                        Name = reader.GetString(0)
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
        
SELECT COLUMN_NAME, DATA_TYPE, IS_NULLABLE, COLUMN_COMMENT
FROM information_schema.COLUMNS
WHERE TABLE_SCHEMA = 'DataBase'
AND TABLE_NAME = 'Table'
         
         */
    }
}
