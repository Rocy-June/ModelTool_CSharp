using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTool_CSharp
{
    static class Extend
    {
        public static int ToInt(this object obj)
        {
            try { return Convert.ToInt32(obj); } catch { return 0; }
        }
    }
}
