using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTool.Model
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

        public string ModelName { get; set; }

        public bool UseSummary { get; set; }

        public List<ColumnInfo> Columns { get; set; }
    }
}
