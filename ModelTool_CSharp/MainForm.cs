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

namespace ModelTool_CSharp
{
    public partial class MainForm : Form
    {
        private readonly string dataFilePath = $"{Environment.CurrentDirectory}\\setting.ini";
        private readonly string usingSplitter = "{{line}}";

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            ip_box.Text = IniHelper.Read("Setting", "IP", ip_box.Text, dataFilePath);
            account_box.Text = IniHelper.Read("Setting", "Account", account_box.Text, dataFilePath);
            using_box.Text = IniHelper.Read("Setting", "Using", using_box.Text, dataFilePath).Replace("{{line}}", @"
");
            namespace_box.Text = IniHelper.Read("Setting", "Namespace", namespace_box.Text, dataFilePath);
            accessModifier_comboBox.Text = IniHelper.Read("Setting", "AccessModifier", accessModifier_comboBox.Text, dataFilePath);
            space_numBox.Value = IniHelper.Read("Setting", "TabSpace", space_numBox.Value.ToString(), dataFilePath).ToInt();
            useSummary_checkBox.Checked = IniHelper.Read("Setting", "UseSummary", useSummary_checkBox.Checked.ToString(), dataFilePath).ToBool();
            saveLocation_box.Text = IniHelper.Read("Setting", "SaveLocation", saveLocation_box.Text, dataFilePath);
        }

        private string GetConnectionString()
        {
            return $"Server={ip_box.Text};Uid={account_box.Text};Pwd={password_box.Text}";
        }

        private void GetDatabases()
        {
            IniHelper.Write("Setting", "IP", ip_box.Text, dataFilePath);
            IniHelper.Write("Setting", "Account", account_box.Text, dataFilePath);

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
            if (!Directory.Exists(saveLocation_box.Text))
            {
                Directory.CreateDirectory(saveLocation_box.Text);
            }

            var loadingForm = new WaitForm(dataTableCheckList.CheckedItems.Count);
            var connStr = GetConnectionString();
            var database = database_comboBox.Text;
            var modelSetting = new ModelSetting()
            {
                Using = using_box.Text,
                Namespace = namespace_box.Text,
                TabSpace = space_numBox.Value.ToInt(),
                AccessModifier = accessModifier_comboBox.Text,
                UseSummary = useSummary_checkBox.Checked
            };
            var hasGenerateError = false;

            var thread = new Thread(() =>
            {
                for (var i = 0; i < dataTableCheckList.CheckedItems.Count; ++i)
                {
                    try
                    {
                        var model_name = dataTableCheckList.CheckedItems[i].ToString();

                        loadingForm.RefreshState(i + 1, $"正在生成: {model_name}.cs");

                        modelSetting.ModelName = model_name;
                        modelSetting.Columns = SQL.GetColumns(connStr, database, model_name);

                        var generated_text = ModelGenerator.Generate(modelSetting);

                        using (var sw = new StreamWriter($"{saveLocation_box.Text}\\{model_name}.cs"))
                        {
                            sw.Write(generated_text);
                        }
                    }
                    catch (Exception ex)
                    {
                        hasGenerateError = true;

                        var logFilePath = $"{saveLocation_box.Text}\\error.log";

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
            IniHelper.Write("Setting", "Using", using_box.Text.Replace(@"
", usingSplitter), dataFilePath);
            IniHelper.Write("Setting", "Namespace", namespace_box.Text, dataFilePath);
            IniHelper.Write("Setting", "AccessModifier", accessModifier_comboBox.Text, dataFilePath);
            IniHelper.Write("Setting", "TabSpace", space_numBox.Value.ToString(), dataFilePath);
            IniHelper.Write("Setting", "UseSummary", useSummary_checkBox.Checked.ToString(), dataFilePath);
            IniHelper.Write("Setting", "SaveLocation", saveLocation_box.Text, dataFilePath);
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
            GenerateFile();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }
    }
}
