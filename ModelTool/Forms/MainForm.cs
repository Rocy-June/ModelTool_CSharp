using ModelTool.Core.Generator.Model;
using ModelTool.Core.Helper;
using ModelTool.Core.Model;
using ModelTool.Core.Generator.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Settings = ModelTool.Properties.Settings;
using ModelTool.Forms.Helper;

namespace ModelTool.Forms
{
    public partial class MainForm : Form
    {

        public SqlGeneratorSetting SqlGeneratorSetting { get; set; }

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
            using (var cf = new ConnectForm())
            {
                cf.ShowDialog();
                if (cf.DialogResult == DialogResult.OK)
                {
                    SqlGeneratorSetting = cf.ConnectionResult;

                    TestDatabaseAndConnect();
                }
                else 
                {
                    CheckedListBox_DataTable.Items.Clear();
                    ComboBox_Database.Items.Clear();
                }
            }
        }

        public bool TestDatabaseAndConnect()
        {
            if (SqlGeneratorSetting == null)
            {
                Alert.Error("请先连接数据库");
                return false;
            }

            using (var uniGen = new UniversalGenerator(SqlGeneratorSetting))
            {
                if (!uniGen.TryGetConnection(out var message))
                {
                    Alert.Error(message);
                    return false;
                }

                if (!GetDatabases(uniGen))
                {
                    return false;
                }

                if (!GetTables(uniGen))
                {
                    return true;
                }

                RefreshModelText(uniGen);
            }

            return true;
        }

        public void TestTableAndConnect()
        {
            if (SqlGeneratorSetting == null)
            {
                Alert.Error("请先连接数据库");
                return;
            }

            using (var uniGen = new UniversalGenerator(SqlGeneratorSetting))
            {
                if (!uniGen.TryGetConnection(out string message))
                {
                    Alert.Error(message);
                    return;
                }

                if (!GetTables(uniGen))
                {
                    return;
                }

                RefreshModelText(uniGen);
            }

            return;
        }

        private bool GetDatabases(UniversalGenerator uniGen)
        {
            try
            {
                var list = uniGen.GetDatabases();

                ComboBox_Database.Items.Clear();
                ComboBox_Database.Items.AddRange(list.ToArray());
                ComboBox_Database.Text = list.Count > 0 ? list[list.Count - 1] : string.Empty;
            }
            catch (Exception ex)
            {
#if DEBUG
                Console.WriteLine($@"{ex.Message}
{ex.StackTrace}");
#endif

                Alert.Error(ex.Message);
                return false;
            }

            return true;
        }

        private bool GetTables(UniversalGenerator uniGen)
        {
            try
            {
                var list = uniGen.GetTables(ComboBox_Database.Text);

                CheckedListBox_DataTable.Items.Clear();
                CheckedListBox_DataTable.Items.AddRange(list.ToArray());
                CheckedListBox_DataTable.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
#if DEBUG
                Console.WriteLine($@"{ex.Message}
{ex.StackTrace}");
#endif

                Alert.Error(ex.Message);
                return false;
            }

            return true;
        }

        private void RefreshModelText(UniversalGenerator uniGen)
        {
            try
            {
                var list = uniGen.GetColumns(ComboBox_Database.Text, CheckedListBox_DataTable.Text);

                TextBox_Generated.Text = ModelGenerator.Generate(new ModelSetting()
                {
                    Using = TextBox_Using.Text,
                    Namespace = TextBox_NameSpace.Text,
                    TabSpace = NumBox_TabSpace.Value.ToInt(),
                    AccessModifier = ComboBox_AccessModifier.Text,
                    ModelName = CheckedListBox_DataTable.Text,
                    UseSummary = CheckBox_UseSummary.Checked,
                    Columns = list
                });
            }
            catch (Exception ex)
            {
#if DEBUG
                Console.WriteLine($@"{ex.Message}
{ex.StackTrace}");
#endif

                Alert.Error(ex.Message);
                return;
            }
        }

        private void GenerateSettingChanged()
        {
            if (CheckedListBox_DataTable.SelectedIndex >= 0)
            {
                if (SqlGeneratorSetting == null)
                {
                    Alert.Error("请先连接数据库");
                    return;
                }

                using (var uniGen = new UniversalGenerator(SqlGeneratorSetting))
                {
                    if (!uniGen.TryGetConnection(out var message))
                    {
                        Alert.Error(message);
                        return;
                    }

                    RefreshModelText(uniGen);
                }
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
            if (SqlGeneratorSetting == null)
            {
                Alert.Error("请先连接数据库");
                return;
            }
            if (string.IsNullOrWhiteSpace(ComboBox_Database.Text))
            {
                Alert.Error("请先选择数据库并勾选需要生成的表单");
                return;
            }
            if (CheckedListBox_DataTable.CheckedItems.Count <= 0)
            {
                Alert.Error("请先勾选需要生成的表单");
                return;
            }
            if (string.IsNullOrWhiteSpace(TextBox_SaveLocation.Text) && !ChangeSavePath())
            {
                Alert.Error("请选择生成位置");
                return;
            }
            if (!Directory.Exists(TextBox_SaveLocation.Text))
            {
                Directory.CreateDirectory(TextBox_SaveLocation.Text);
            }

            using (var loadingForm = new WaitForm("正在生成", CheckedListBox_DataTable.CheckedItems.Count))
            {
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
                    using (var uniGen = new UniversalGenerator(SqlGeneratorSetting))
                    {
                        if (!uniGen.TryGetConnection(out var message))
                        {
                            Alert.Error(message);
                            loadingForm.WorkComplete();
                            return;
                        }

                        for (var i = 0; i < CheckedListBox_DataTable.CheckedItems.Count; ++i)
                        {
                            try
                            {
                                var modelName = CheckedListBox_DataTable.CheckedItems[i].ToString();

                                loadingForm.RefreshState(i + 1, $"正在生成: {modelName}.cs");

                                modelSetting.ModelName = modelName;
                                modelSetting.Columns = uniGen.GetColumns(database, modelName);

                                var generated_text = ModelGenerator.Generate(modelSetting);

                                using (var sw = new StreamWriter($"{TextBox_SaveLocation.Text}\\{modelName}.cs"))
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
                    }

                    loadingForm.WorkComplete();
                })
                {
                    IsBackground = true
                };

                loadingForm.StartWork(thread);

                if (hasGenerateError)
                {
                    Alert.Warning("生成已完成，但出现错误，错误报告已生成在与实体类相同的目录下");
                }
                else
                {
                    Alert.Info("生成已完成");
                }
            }
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
            if (SqlGeneratorSetting == null)
            {
                Alert.Error("请先连接数据库");
                return;
            }

            using (var uniGen = new UniversalGenerator(SqlGeneratorSetting))
            {
                if (!uniGen.TryGetConnection(out var message))
                {
                    Alert.Error(message);
                    return;
                }

                RefreshModelText(uniGen);
            }
        }

        private void Button_SelectAllTables_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < CheckedListBox_DataTable.Items.Count; ++i)
            {
                CheckedListBox_DataTable.SetItemChecked(i, true);
            }
        }

        private void Button_ReverseTableSelect_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < CheckedListBox_DataTable.Items.Count; ++i)
            {
                CheckedListBox_DataTable.SetItemChecked(i, !CheckedListBox_DataTable.GetItemChecked(i));
            }
        }

        private void Button_ClearTableSelect_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < CheckedListBox_DataTable.Items.Count; ++i)
            {
                CheckedListBox_DataTable.SetItemChecked(i, false);
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
