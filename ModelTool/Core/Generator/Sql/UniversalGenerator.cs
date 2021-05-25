using ModelTool.Core.Generator.Sql.Base;
using ModelTool.Core.Generator.Sql.Interface;
using ModelTool.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTool.Core.Generator.Sql
{
    public class UniversalGenerator : ISqlGenerator
    {
        public SqlGeneratorSetting Setting { get; }

        public ISqlGenerator Generator { get; set; }

        public UniversalGenerator(SqlGeneratorSetting setting)
        {
            Setting = setting;

            switch (setting.SqlType)
            {
                case SqlType.MSSQLSERVER:
                    Generator = new MSSQLServerGenerator(setting);
                    break;
                case SqlType.MySQL:
                    Generator = new MySQLGenerator(setting);
                    break;
                case SqlType.Oracle:
                    throw new NotSupportedException();
                default:
                    throw new ArgumentException();
            }
        }

        public DbConnection GetConnection()
        {
            return Generator.GetConnection();
        }

        public List<string> GetDatabases()
        {
            return Generator.GetDatabases();
        }

        public List<string> GetTables(string database)
        {
            return Generator.GetTables(database);
        }

        public List<ColumnInfo> GetColumns(string database, string table)
        {
            return Generator.GetColumns(database, table);
        }

        public void Dispose()
        {
            Generator.Dispose();
        }
    }
}
