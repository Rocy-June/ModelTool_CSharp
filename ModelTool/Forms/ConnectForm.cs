using ModelTool.Model;
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
        MainForm Parent_MainForm { get; }
        public ConnectForm(MainForm mf)
        {
            InitializeComponent();

            Parent_MainForm = mf;

            Init();
        }

        public void Init()
        {
            ComboBox_SqlType.SelectedIndex = 0;
            TextBox_IP.Text = Settings.Default.IP;
            TextBox_Account.Text = Settings.Default.Account;
        }

        public new void Show()
        {
            ShowDialog();
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
            if (!IPAddress.TryParse(TextBox_IP.Text, out var ipAddress))
            {
                MessageBox.Show("请正确输入IP地址", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(TextBox_Account.Text))
            {
                MessageBox.Show("请输入连接用户名", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Settings.Default.IP = TextBox_IP.Text;
            Settings.Default.Account = TextBox_Account.Text;

            Settings.Default.Save();

            Parent_MainForm.SqlGeneratorSetting = new SqlGeneratorSetting
            {
                SqlType = (SqlType)ComboBox_SqlType.SelectedIndex,
                ServerAddress = ipAddress,
                UserAccount = TextBox_Account.Text,
                UserPassword = TextBox_Password.Text
            };

            if (Parent_MainForm.TestDatabaseAndConnect())
            {
                Close();
            }
        }
    }
}
