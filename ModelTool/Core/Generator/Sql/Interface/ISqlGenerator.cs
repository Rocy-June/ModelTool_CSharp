﻿using ModelTool.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTool.Core.Generator.Sql.Interface
{
    public interface ISqlGenerator : IDisposable
    {
        SqlGeneratorSetting Setting { get; }

        bool TryGetConnection(out string message);

        List<string> GetDatabases();

        List<string> GetTables(string database);

        List<ColumnInfo> GetColumns(string database, string table);
    }
}
