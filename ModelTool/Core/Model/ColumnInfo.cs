using System;

namespace ModelTool.Core.Model
{
    public class ColumnInfo
    {
        public bool IsPrimaryKey { get; set; }

        public bool IsIdentity { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public bool IsNullable { get; set; }

        public string Summary { get; set; }
    }
}
