using ModelTool_CSharp.Core;
using ModelTool_CSharp.Helper;
using ModelTool_CSharp.Model;
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

using Settings = ModelTool_CSharp.Properties.Settings;

namespace ModelTool_CSharp.Forms
{
    public partial class MainForm : Form
    {

        public string ConnectionString { get; set; }

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            TextBox_Using.Text = Settings.Default.Using;
            TextBox_NameSpace.Text = Settings.Default.Namespace;
            ComboBox_AccessModifier.Text = Settings.Default.Namespace;
            NumBox_TabSpace.Value = Settings.Default.TabSpace;
            CheckBox_UseSummary.Checked = Settings.Default.UseSummary;
            TextBox_SaveLocation.Text = Settings.Default.SaveLocation;
        }

        private void OpenConnectForm()
        {
            var cf = new ConnectForm(this);
            cf.ShowDialog();
        }

        public bool TestDatabaseAndConnect()
        {
            if (!GetDatabases())
            {
                return false;
            }

            if (!GetTables())
            {
                return true;
            }

            RefreshModelText();

            return true;
        }

        public bool TestTableAndConnect()
        {
            if (!GetTables())
            {
                return true;
            }

            RefreshModelText();

            return true;
        }

        private bool GetDatabases()
        {
            if (string.IsNullOrWhiteSpace(ConnectionString))
            {
                MessageBox.Show("请先连接数据库", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                var list = SQL.GetDatabases(ConnectionString);

                ComboBox_Database.Items.Clear();
                ComboBox_Database.Items.AddRange(list.ToArray());
                ComboBox_Database.Text = list.Count > 0 ? list[list.Count - 1] : string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        private bool GetTables()
        {
            if (string.IsNullOrWhiteSpace(ConnectionString))
            {
                MessageBox.Show("请先连接数据库", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                var list = SQL.GetTables(ConnectionString, ComboBox_Database.Text);

                CheckList_DataTable.Items.Clear();
                CheckList_DataTable.Items.AddRange(list.ToArray());
                CheckList_DataTable.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        private void RefreshModelText()
        {
            if (string.IsNullOrWhiteSpace(ConnectionString))
            {
                MessageBox.Show("请先连接数据库", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var list = SQL.GetColumns(ConnectionString, ComboBox_Database.Text, CheckList_DataTable.Text);

                TextBox_Generated.Text = ModelGenerator.Generate(new ModelSetting()
                {
                    Using = TextBox_Using.Text,
                    Namespace = TextBox_NameSpace.Text,
                    TabSpace = NumBox_TabSpace.Value.ToInt(),
                    AccessModifier = ComboBox_AccessModifier.Text,
                    ModelName = CheckList_DataTable.Text,
                    UseSummary = CheckBox_UseSummary.Checked,
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
            if (CheckList_DataTable.SelectedIndex >= 0)
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
                var tmpDirName = string.IsNullOrWhiteSpace(TextBox_NameSpace.Text) ? "Model" : TextBox_NameSpace.Text;
                if (dir.Name != tmpDirName)
                {
                    tmpDirName = $"{selector.SelectedPath}\\{tmpDirName}";
                }
                TextBox_SaveLocation.Text = tmpDirName;

                return true;
            }
            return false;
        }

        private void GenerateFile()
        {
            if (string.IsNullOrWhiteSpace(ConnectionString))
            {
                MessageBox.Show("请先连接数据库", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(ComboBox_Database.Text))
            {
                MessageBox.Show("请先选择数据库并勾选需要生成的表单", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CheckList_DataTable.CheckedItems.Count <= 0)
            {
                MessageBox.Show("请先勾选需要生成的表单", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(TextBox_SaveLocation.Text) && !ChangeSavePath())
            {
                MessageBox.Show("请选择生成位置", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(TextBox_SaveLocation.Text))
            {
                Directory.CreateDirectory(TextBox_SaveLocation.Text);
            }

            var loadingForm = new WaitForm(CheckList_DataTable.CheckedItems.Count);
            var database = ComboBox_Database.Text;
            var modelSetting = new ModelSetting()
            {
                Using = TextBox_Using.Text,
                Namespace = TextBox_NameSpace.Text,
                TabSpace = NumBox_TabSpace.Value.ToInt(),
                AccessModifier = ComboBox_AccessModifier.Text,
                UseSummary = CheckBox_UseSummary.Checked
            };
            var hasGenerateError = false;

            var thread = new Thread(() =>
            {
                for (var i = 0; i < CheckList_DataTable.CheckedItems.Count; ++i)
                {
                    try
                    {
                        var model_name = CheckList_DataTable.CheckedItems[i].ToString();

                        loadingForm.RefreshState(i + 1, $"正在生成: {model_name}.cs");

                        modelSetting.ModelName = model_name;
                        modelSetting.Columns = SQL.GetColumns(ConnectionString, database, model_name);

                        var generated_text = ModelGenerator.Generate(modelSetting);

                        using (var sw = new StreamWriter($"{TextBox_SaveLocation.Text}\\{model_name}.cs"))
                        {
                            sw.Write(generated_text);
                        }
                    }
                    catch (Exception ex)
                    {
                        hasGenerateError = true;

                        var logFilePath = $"{TextBox_SaveLocation.Text}\\error.log";

                        if (!File.Exists(logFilePath))
                        {
                            var fs = File.Create(logFilePath);
                            fs.Dispose();
                        }
                        using (var sw = new StreamWriter(logFilePath, true))
                        {
                            sw.WriteLine($@"=== Exception log {DateTime.Now:yyyy-MM-dd hh:mm:ss} BEGINS ===

Exception message:
{ex.Message}

Exception stack trace:
{ex.StackTrace}

=== Exception log ENDS ===");
                        }
                    }
                }

                loadingForm.WorkComplete();
            })
            {
                IsBackground = true
            };

            loadingForm.StartWork(thread);

            if (hasGenerateError)
            {
                MessageBox.Show(@"生成已完成，但出现错误，错误报告已生成在与实体类相同的目录下", "出错", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MessageBox.Show(@"生成已完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveData()
        {
            Settings.Default.Using = TextBox_Using.Text;
            Settings.Default.Namespace = TextBox_NameSpace.Text;
            Settings.Default.AccessModifier = ComboBox_AccessModifier.Text;
            Settings.Default.TabSpace = NumBox_TabSpace.Value.ToInt();
            Settings.Default.UseSummary = CheckBox_UseSummary.Checked;
            Settings.Default.SaveLocation = TextBox_SaveLocation.Text;

            Settings.Default.Save();
        }









        private void ToolStripMenuItem_NewConnection_Click(object sender, EventArgs e)
        {
            OpenConnectForm();
        }

        private void ComboBox_Database_SelectedIndexChanged(object sender, EventArgs e)
        {
            TestTableAndConnect();
        }

        private void Button_RefreshTableList_Click(object sender, EventArgs e)
        {
            TestTableAndConnect();
        }

        private void Button_RefreshDatabaseList_Click(object sender, EventArgs e)
        {
            TestDatabaseAndConnect();
        }

        private void CheckList_DataTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshModelText();
        }

        private void Button_SelectAllTables_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < CheckList_DataTable.Items.Count; ++i)
            {
                CheckList_DataTable.SetItemChecked(i, true);
            }
        }

        private void Button_ReverseTableSelect_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < CheckList_DataTable.Items.Count; ++i)
            {
                CheckList_DataTable.SetItemChecked(i, !CheckList_DataTable.GetItemChecked(i));
            }
        }

        private void Button_ClearTableSelect_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < CheckList_DataTable.Items.Count; ++i)
            {
                CheckList_DataTable.SetItemChecked(i, false);
            }
        }

        private void TextBox_Using_Validating(object sender, CancelEventArgs e)
        {
            GenerateSettingChanged();
        }

        private void TextBox_NameSpace_Validating(object sender, CancelEventArgs e)
        {
            GenerateSettingChanged();
        }

        private void ComboBox_AccessModifier_Validating(object sender, CancelEventArgs e)
        {
            GenerateSettingChanged();
        }

        private void NumBox_TabSpace_Validating(object sender, CancelEventArgs e)
        {
            GenerateSettingChanged();
        }

        private void CheckBox_UseSummary_CheckedChanged(object sender, EventArgs e)
        {
            GenerateSettingChanged();
        }

        private void Button_EditLocation_Click(object sender, EventArgs e)
        {
            ChangeSavePath();
        }

        private void Button_StartGenerate_Click(object sender, EventArgs e)
        {
            GenerateFile();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }
    }
}
