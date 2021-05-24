using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTool.Helper
{
    static class Extend
    {
        public static int ToInt(this object obj)
        {
            try { return Convert.ToInt32(obj); } catch { return 0; }
        }

        public static bool ToBool(this string obj, bool def = true)
        {
            return bool.TryParse(obj, out var result) ? result : def;
        }
    }
}
