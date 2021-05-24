using ModelTool.Model;
using ModelTool_CSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTool_CSharp.Core.Generator.Sql
{
    public abstract class SqlGenerator<T> : IDisposable where T : IDisposable
    {
        protected SqlGeneratorSetting Setting { get; }

        protected T Connection { get; }

        protected SqlGenerator(SqlGeneratorSetting setting)
        {
            Setting = setting;
            Connection = GetConnection();
        }

        public abstract T GetConnection();

        public abstract List<string> GetDatabases();

        public abstract List<string> GetTables(string datebase);

        public abstract List<ColumnInfo> GetColumns(string database, string table);

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
