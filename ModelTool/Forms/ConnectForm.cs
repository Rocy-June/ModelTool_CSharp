using ModelTool.Core.Model;
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
            TextBox_IP.Text = Settings.Default.IP;
            TextBox_Account.Text = Settings.Default.Account;
        }

        public new DialogResult Show()
        {
            return ShowDialog();
        }

        private void ComboBox_SqlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_SqlType.SelectedIndex == 2)
            {
                MessageBox.Show("Oracle数据库暂未完成具体实现, 请等待后续更新...", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ComboBox_SqlType.SelectedIndex = 0;
            }
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
                DialogResult = DialogResult.Cancel;
                return;
            }
            if (string.IsNullOrWhiteSpace(TextBox_Account.Text))
            {
                MessageBox.Show("请输入连接用户名", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                return;
            }

            Settings.Default.DataBaseTypeSelectedIndex = ComboBox_SqlType.SelectedIndex;
            Settings.Default.IP = TextBox_IP.Text;
            Settings.Default.Account = TextBox_Account.Text;

            Settings.Default.Save();

            ConnectionResult = new SqlGeneratorSetting
            {
                SqlType = (SqlType)ComboBox_SqlType.SelectedIndex,
                ServerAddress = ipAddress,
                UserAccount = TextBox_Account.Text,
                UserPassword = TextBox_Password.Text
            };
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
