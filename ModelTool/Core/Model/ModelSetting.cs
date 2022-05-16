using System;
using System.Collections.Generic;

namespace ModelTool.Core.Model
{
    class ModelSetting
    {
        public ModelSetting()
        {
            Columns = new List<ColumnInfo>();
        }

        public string Using { get; set; }

        public string Namespace { get; set; }

        public int TabSpace { get; set; }

        public string AccessModifier { get; set; }

        public string Inherit { get; set; }

        public string ModelName { get; set; }

        public string ModelSummary { get; set; }

        public bool UseSummary { get; set; }

        public bool EnableSQLSugarSupport { get; set; }

        public List<ColumnInfo> Columns { get; set; }
    }
}
