using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTool_CSharp.Model
{
    class ColumnInfo
    {
        public string Summary { get; set; }

        public string Type { get; set; }

        public bool IsNullable { get; set; }

        public string Name { get; set; }
    }
}
