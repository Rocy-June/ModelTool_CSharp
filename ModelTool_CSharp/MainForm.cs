using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelTool_CSharp
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private string GetConnectionString()
        {
            return $"Server={ip_box.Text};Uid={account_box.Text};Pwd={password_box.Text}";
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(GetConnectionString());
        }

        private void GetDatabases()
        {
            using (var con = GetConnection())
            {
                con.Open();

                var getDatabaseStr = "SELECT Name FROM Master..SysDatabases ORDER BY Name";
                using (var cmd = new SqlCommand(getDatabaseStr, con))
                {
                    var reader = cmd.ExecuteReader();

                    var databaseList = new List<string>();
                    while (reader.Read())
                    {
                        databaseList.Add(reader.GetString(0));
                    }

                    database_comboBox.Items.Clear();
                    database_comboBox.Items.AddRange(databaseList.ToArray());
                    database_comboBox.Text = databaseList.Count > 0 ? databaseList[databaseList.Count - 1] : string.Empty;

                    GetTables();
                }
            }
        }

        private void GetTables()
        {
            using (var con = GetConnection())
            {
                con.Open();

                var getTableStr = $"SELECT Name FROM {database_comboBox.Text}..SysObjects Where XType='U' ORDER BY Name";
                using (var cmd = new SqlCommand(getTableStr, con))
                {
                    var reader = cmd.ExecuteReader();

                    var tableList = new List<string>();
                    while (reader.Read())
                    {
                        tableList.Add(reader.GetString(0));
                    }

                    dataTableCheckList.Items.Clear();
                    dataTableCheckList.Items.AddRange(tableList.ToArray());
                    dataTableCheckList.SelectedIndex = 0;
                }
            }
        }

        private void connect_button_Click(object sender, EventArgs e)
        {

            try
            {
                GetDatabases();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void refreshTableList_button_Click(object sender, EventArgs e)
        {
            try
            {
                GetTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
