using System.Net;

namespace ModelTool.Core.Model
{
    public class SqlGeneratorSetting
    {
        public SqlType SqlType { get; set; }

        public IPAddress ServerAddress { get; set; }

        public string SqlInstanceName { get; set; }

        public string UserAccount { get; set; }

        public string UserPassword { get; set; }
    }
}
