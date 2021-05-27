using ModelTool.Core.Generator.Sql.Interface;
using ModelTool.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ModelTool.Core.Generator.Sql.Base
{
    class MySQLGenerator : ISqlGenerator
    {
        public SqlGeneratorSetting Setting { get; }

        private MySqlConnection Connection { get; }

        private const string IS_NULLABLE_YES = "YES";

        public MySQLGenerator(SqlGeneratorSetting setting) 
        {
            Setting = setting;
            Connection = GetConnection() as MySqlConnection;
        }

        public DbConnection GetConnection()
        {
            return new MySqlConnection($"Server={Setting.ServerAddress};Uid={Setting.UserAccount};Pwd={Setting.UserPassword}");
        }

        public List<string> GetDatabases()
        {
            try
            {
                Connection.Open();

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
        
SELECT COLUMN_NAME, DATA_TYPE, IS_NULLABLE, COLUMN_COMMENT
FROM information_schema.COLUMNS
WHERE TABLE_SCHEMA = 'DataBase'
AND TABLE_NAME = 'Table'
         
         */
    }
}
