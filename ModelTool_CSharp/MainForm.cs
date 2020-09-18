using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelTool_CSharp
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            ip_box.Text = Properties.Settings.Default.IP;
            account_box.Text = Properties.Settings.Default.Account;
            using_box.Text = Properties.Settings.Default.Using;
            namespace_box.Text = Properties.Settings.Default.Namespace;
            accessModifier_comboBox.Text = Properties.Settings.Default.AccessModifier;
            space_numBox.Value = Properties.Settings.Default.TabSpace;
            useSummary_checkBox.Checked = Properties.Settings.Default.UseSummary;
            saveLocation_box.Text = Properties.Settings.Default.SaveLocation;
        }

        private string GetConnectionString()
        {
            return $"Server={ip_box.Text};Uid={account_box.Text};Pwd={password_box.Text}";
        }

        private void GetDatabases()
        {
            Properties.Settings.Default.IP = ip_box.Text;
            Properties.Settings.Default.Account = account_box.Text;

            try
            {
                var list = SQL.GetDatabases(GetConnectionString());

                database_comboBox.Items.Clear();
                database_comboBox.Items.AddRange(list.ToArray());
                database_comboBox.Text = list.Count > 0 ? list[list.Count - 1] : string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void GetTables()
        {
            try
            {
                var list = SQL.GetTables(GetConnectionString(), database_comboBox.Text);

                dataTableCheckList.Items.Clear();
                dataTableCheckList.Items.AddRange(list.ToArray());
                dataTableCheckList.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void RefreshModelText()
        {
            try
            {
                var list = SQL.GetColumns(GetConnectionString(), database_comboBox.Text, dataTableCheckList.Text);

                GeneratedText.Text = ModelGenerator.Generate(new ModelSetting()
                {
                    Using = using_box.Text,
                    Namespace = namespace_box.Text,
                    TabSpace = space_numBox.Value.ToInt(),
                    AccessModifier = accessModifier_comboBox.Text,
                    ModelName = dataTableCheckList.Text,
                    UseSummary = useSummary_checkBox.Checked,
                    Columns = list
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void GenerateSettingChanged()
        {
            if (dataTableCheckList.SelectedIndex >= 0)
            {
                RefreshModelText();
            }
        }

        private bool ChangeSavePath()
        {
            var selector = new FolderBrowserDialog();
            selector.ShowDialog();

            if (!string.IsNullOrWhiteSpace(selector.SelectedPath))
            {
                var dir = new DirectoryInfo(selector.SelectedPath);
                var tmpDirName = string.IsNullOrWhiteSpace(namespace_box.Text) ? "Model" : namespace_box.Text;
                if (dir.Name != tmpDirName)
                {
                    tmpDirName = $"{selector.SelectedPath}\\{tmpDirName}";
                }
                saveLocation_box.Text = tmpDirName;

                return true;
            }
            return false;
        }

        private void GenerateFile()
        {
            if (string.IsNullOrWhiteSpace(password_box.Text))
            {
                MessageBox.Show("请先连接数据库", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(database_comboBox.Text))
            {
                MessageBox.Show("请先选择数据库并勾选需要生成的表单", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataTableCheckList.CheckedItems.Count <= 0)
            {
                MessageBox.Show("请先勾选需要生成的表单", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(saveLocation_box.Text) && !ChangeSavePath())
            {
                MessageBox.Show("请选择生成位置", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var loadingForm = new GeneratingForm(dataTableCheckList.CheckedItems.Count);

            var thread = new Thread(() =>
            {
                for (var i = 0; i < dataTableCheckList.CheckedItems.Count; ++i)
                {
                    var table_name = dataTableCheckList.CheckedItems[i].ToString();

                    var generated_text = ModelGenerator.Generate(new ModelSetting()
                    {
                        Using = using_box.Text,
                        Namespace = namespace_box.Text,
                        TabSpace = space_numBox.Value.ToInt(),
                        AccessModifier = accessModifier_comboBox.Text,
                        ModelName = dataTableCheckList.Text,
                        UseSummary = useSummary_checkBox.Checked,
                        Columns = SQL.GetColumns(GetConnectionString(), database_comboBox.Text, table_name)
                    });

                    loadingForm.RefreshState(i + 1,$"正在生成: {table_name}.cs");
                }
            })
            {
                IsBackground = true
            };
            thread.Start();

            loadingForm.ShowDialog();

        }

        private void SaveData()
        {
            Properties.Settings.Default.Using = using_box.Text;
            Properties.Settings.Default.Namespace = namespace_box.Text;
            Properties.Settings.Default.AccessModifier = accessModifier_comboBox.Text;
            Properties.Settings.Default.TabSpace = space_numBox.Value.ToInt();
            Properties.Settings.Default.UseSummary = useSummary_checkBox.Checked;
            Properties.Settings.Default.SaveLocation = saveLocation_box.Text;

            Properties.Settings.Default.Save();
        }








        private void connect_button_Click(object sender, EventArgs e)
        {
            GetDatabases();

            GetTables();

            RefreshModelText();
        }

        private void database_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTables();

            RefreshModelText();
        }

        private void refreshTableList_button_Click(object sender, EventArgs e)
        {
            GetTables();

            RefreshModelText();
        }

        private void dataTableCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshModelText();
        }

        private void tableSelectAll_button_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < dataTableCheckList.Items.Count; ++i)
            {
                dataTableCheckList.SetItemChecked(i, true);
            }
        }

        private void tableReverseSelect_button_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < dataTableCheckList.Items.Count; ++i)
            {
                dataTableCheckList.SetItemChecked(i, !dataTableCheckList.GetItemChecked(i));
            }
        }

        private void tableClearSelect_button_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < dataTableCheckList.Items.Count; ++i)
            {
                dataTableCheckList.SetItemChecked(i, false);
            }
        }

        private void using_box_Validating(object sender, CancelEventArgs e)
        {
            GenerateSettingChanged();
        }

        private void namespace_box_Validating(object sender, CancelEventArgs e)
        {
            GenerateSettingChanged();
        }

        private void accessModifier_comboBox_Validating(object sender, CancelEventArgs e)
        {
            GenerateSettingChanged();
        }

        private void space_numBox_Validating(object sender, CancelEventArgs e)
        {
            GenerateSettingChanged();
        }

        private void useSummary_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            GenerateSettingChanged();
        }

        private void editLocation_button_Click(object sender, EventArgs e)
        {
            ChangeSavePath();
        }

        private void startGenerate_button_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }
    }
}
