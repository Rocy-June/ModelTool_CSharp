using System.Net;

namespace ModelTool.Core.Model
{
    public class SqlGeneratorSetting
    {
        public IPAddress ServerAddress { get; set; }

        public SqlType SqlType { get; set; }

        public string UserAccount { get; set; }

        public string UserPassword { get; set; }
    }
}
