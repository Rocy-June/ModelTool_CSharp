using ModelTool.Core.Generator.Sql.Base;
using ModelTool.Core.Model;
using ModelTool.Forms.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Settings = ModelTool.Properties.Settings;

namespace ModelTool.Forms
{
    public partial class ConnectForm : Form
    {
        private const string LOCALHOST_IP = "127.0.0.1";
        public SqlGeneratorSetting ConnectionResult { get; private set; }

        public ConnectForm()
        {
            InitializeComponent();

            DialogResult = DialogResult.Cancel;

            Init();
        }

        public void Init()
        {
            ComboBox_SqlType.SelectedIndex = Settings.Default.DataBaseTypeSelectedIndex;
            TextBox_InstanceName.Text = Settings.Default.SqlInstanceName;
            CheckBox_Localhost.Checked = Settings.Default.IsLocalhostIP;
            TextBox_IP.Text = Settings.Default.IP;
            TextBox_Account.Text = Settings.Default.Account;
        }

        public new DialogResult Show()
        {
            return ShowDialog();
        }

        private void ComboBox_SqlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_SqlType.SelectedIndex == 0)
            {
                TextBox_InstanceName.Text = MSSQLServerGenerator.DEFAULT_INSTANCE_NAME;
            }

            TextBox_InstanceName.Text = string.Empty;

            if (ComboBox_SqlType.SelectedIndex == 2)
            {
                Alert.Info("Oracle数据库暂未完成具体实现, 请等待后续更新...");
                ComboBox_SqlType.SelectedIndex = 0;
            }
        }

        private void CheckBox_Localhost_CheckedChanged(object sender, EventArgs e)
        {
            TextBox_IP.Text = CheckBox_Localhost.Checked ? "localhost" : string.Empty;
            TextBox_IP.Enabled = !CheckBox_Localhost.Checked;
        }

        private void TextBox_IP_TextChanged(object sender, EventArgs e)
        {
            TextBox_IP.Text = TextBox_IP.Text.Trim();
        }

        private void TextBox_Account_TextChanged(object sender, EventArgs e)
        {
            TextBox_Account.Text = TextBox_Account.Text.Trim();
        }

        private void TextBox_Password_TextChanged(object sender, EventArgs e)
        {
            TextBox_Password.Text = TextBox_Password.Text.Trim();
        }

        private void Button_Connect_Click(object sender, EventArgs e)
        {
            IPAddress ipAddress;
            if (CheckBox_Localhost.Checked)
            {
                ipAddress = IPAddress.Parse(LOCALHOST_IP);
            }
            else if (!IPAddress.TryParse(TextBox_IP.Text, out ipAddress))
            {
                Alert.Error("请正确输入IP地址");
                DialogResult = DialogResult.Cancel;
                return;
            }
            if (string.IsNullOrWhiteSpace(TextBox_Account.Text))
            {
                Alert.Error("请输入连接用户名");
                DialogResult = DialogResult.Cancel;
                return;
            }

            Settings.Default.DataBaseTypeSelectedIndex = ComboBox_SqlType.SelectedIndex;
            Settings.Default.SqlInstanceName = TextBox_InstanceName.Text;
            Settings.Default.IsLocalhostIP = CheckBox_Localhost.Checked;
            Settings.Default.IP = TextBox_IP.Text;
            Settings.Default.Account = TextBox_Account.Text;

            Settings.Default.Save();

            ConnectionResult = new SqlGeneratorSetting
            {
                SqlType = (SqlType)ComboBox_SqlType.SelectedIndex,
                ServerAddress = ipAddress,
                SqlInstanceName = TextBox_InstanceName.Text,
                UserAccount = TextBox_Account.Text,
                UserPassword = TextBox_Password.Text
            };
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
