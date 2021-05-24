using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ModelTool_CSharp.Model
{
    public class SqlGeneratorSetting
    {
        public IPAddress ServerAddress { get; set; }

        public SqlType SqlType { get; set; }

        public string UserAccount { get; set; }

        public string UserPassword { get; set; }
    }
}
