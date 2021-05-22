namespace ModelTool_CSharp.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckList_DataTable = new System.Windows.Forms.CheckedListBox();
            this.TextBox_Generated = new System.Windows.Forms.TextBox();
            this.Panel_Settings = new System.Windows.Forms.Panel();
            this.Button_RefreshDatabaseList = new System.Windows.Forms.Button();
            this.Button_RefreshTableList = new System.Windows.Forms.Button();
            this.Button_StartGenerate = new System.Windows.Forms.Button();
            this.Button_ClearTableSelect = new System.Windows.Forms.Button();
            this.Button_ReverseTableSelect = new System.Windows.Forms.Button();
            this.Button_EditLocation = new System.Windows.Forms.Button();
            this.Button_SelectAllTables = new System.Windows.Forms.Button();
            this.TextBox_SaveLocation = new System.Windows.Forms.TextBox();
            this.CheckBox_UseSummary = new System.Windows.Forms.CheckBox();
            this.ComboBox_AccessModifier = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBox_NameSpace = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NumBox_TabSpace = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_Using = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBox_Database = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SplitContainer_Main = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_NewConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumBox_TabSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer_Main)).BeginInit();
            this.SplitContainer_Main.Panel1.SuspendLayout();
            this.SplitContainer_Main.Panel2.SuspendLayout();
            this.SplitContainer_Main.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckList_DataTable
            // 
            this.CheckList_DataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckList_DataTable.FormattingEnabled = true;
            this.CheckList_DataTable.Location = new System.Drawing.Point(0, 0);
            this.CheckList_DataTable.Name = "CheckList_DataTable";
            this.CheckList_DataTable.Size = new System.Drawing.Size(325, 825);
            this.CheckList_DataTable.TabIndex = 0;
            this.CheckList_DataTable.SelectedIndexChanged += new System.EventHandler(this.CheckList_DataTable_SelectedIndexChanged);
            // 
            // TextBox_Generated
            // 
            this.TextBox_Generated.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox_Generated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Generated.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Generated.Location = new System.Drawing.Point(371, 0);
            this.TextBox_Generated.Multiline = true;
            this.TextBox_Generated.Name = "TextBox_Generated";
            this.TextBox_Generated.ReadOnly = true;
            this.TextBox_Generated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Generated.Size = new System.Drawing.Size(481, 825);
            this.TextBox_Generated.TabIndex = 1;
            this.TextBox_Generated.Text = "using System;\r\n\r\nnamespace Model\r\n{\r\n\r\n}";
            // 
            // Panel_Settings
            // 
            this.Panel_Settings.Controls.Add(this.Button_RefreshDatabaseList);
            this.Panel_Settings.Controls.Add(this.Button_RefreshTableList);
            this.Panel_Settings.Controls.Add(this.Button_StartGenerate);
            this.Panel_Settings.Controls.Add(this.Button_ClearTableSelect);
            this.Panel_Settings.Controls.Add(this.Button_ReverseTableSelect);
            this.Panel_Settings.Controls.Add(this.Button_EditLocation);
            this.Panel_Settings.Controls.Add(this.Button_SelectAllTables);
            this.Panel_Settings.Controls.Add(this.TextBox_SaveLocation);
            this.Panel_Settings.Controls.Add(this.CheckBox_UseSummary);
            this.Panel_Settings.Controls.Add(this.ComboBox_AccessModifier);
            this.Panel_Settings.Controls.Add(this.label8);
            this.Panel_Settings.Controls.Add(this.TextBox_NameSpace);
            this.Panel_Settings.Controls.Add(this.label7);
            this.Panel_Settings.Controls.Add(this.NumBox_TabSpace);
            this.Panel_Settings.Controls.Add(this.label6);
            this.Panel_Settings.Controls.Add(this.TextBox_Using);
            this.Panel_Settings.Controls.Add(this.label5);
            this.Panel_Settings.Controls.Add(this.ComboBox_Database);
            this.Panel_Settings.Controls.Add(this.label4);
            this.Panel_Settings.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Settings.Location = new System.Drawing.Point(0, 0);
            this.Panel_Settings.Name = "Panel_Settings";
            this.Panel_Settings.Size = new System.Drawing.Size(371, 825);
            this.Panel_Settings.TabIndex = 2;
            // 
            // Button_RefreshDatabaseList
            // 
            this.Button_RefreshDatabaseList.Location = new System.Drawing.Point(211, 48);
            this.Button_RefreshDatabaseList.Name = "Button_RefreshDatabaseList";
            this.Button_RefreshDatabaseList.Size = new System.Drawing.Size(130, 32);
            this.Button_RefreshDatabaseList.TabIndex = 28;
            this.Button_RefreshDatabaseList.Text = "刷新库列表";
            this.Button_RefreshDatabaseList.UseVisualStyleBackColor = true;
            this.Button_RefreshDatabaseList.Click += new System.EventHandler(this.Button_RefreshDatabaseList_Click);
            // 
            // Button_RefreshTableList
            // 
            this.Button_RefreshTableList.Location = new System.Drawing.Point(74, 48);
            this.Button_RefreshTableList.Name = "Button_RefreshTableList";
            this.Button_RefreshTableList.Size = new System.Drawing.Size(130, 32);
            this.Button_RefreshTableList.TabIndex = 27;
            this.Button_RefreshTableList.Text = "刷新表列表";
            this.Button_RefreshTableList.UseVisualStyleBackColor = true;
            this.Button_RefreshTableList.Click += new System.EventHandler(this.Button_RefreshTableList_Click);
            // 
            // Button_StartGenerate
            // 
            this.Button_StartGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_StartGenerate.Location = new System.Drawing.Point(200, 744);
            this.Button_StartGenerate.Name = "Button_StartGenerate";
            this.Button_StartGenerate.Size = new System.Drawing.Size(136, 51);
            this.Button_StartGenerate.TabIndex = 25;
            this.Button_StartGenerate.Text = "开始生成";
            this.Button_StartGenerate.UseVisualStyleBackColor = true;
            this.Button_StartGenerate.Click += new System.EventHandler(this.Button_StartGenerate_Click);
            // 
            // Button_ClearTableSelect
            // 
            this.Button_ClearTableSelect.Location = new System.Drawing.Point(74, 86);
            this.Button_ClearTableSelect.Name = "Button_ClearTableSelect";
            this.Button_ClearTableSelect.Size = new System.Drawing.Size(85, 32);
            this.Button_ClearTableSelect.TabIndex = 11;
            this.Button_ClearTableSelect.Text = "重新选择";
            this.Button_ClearTableSelect.UseVisualStyleBackColor = true;
            this.Button_ClearTableSelect.Click += new System.EventHandler(this.Button_ClearTableSelect_Click);
            // 
            // Button_ReverseTableSelect
            // 
            this.Button_ReverseTableSelect.Location = new System.Drawing.Point(256, 86);
            this.Button_ReverseTableSelect.Name = "Button_ReverseTableSelect";
            this.Button_ReverseTableSelect.Size = new System.Drawing.Size(85, 32);
            this.Button_ReverseTableSelect.TabIndex = 10;
            this.Button_ReverseTableSelect.Text = "列表反选";
            this.Button_ReverseTableSelect.UseVisualStyleBackColor = true;
            this.Button_ReverseTableSelect.Click += new System.EventHandler(this.Button_ReverseTableSelect_Click);
            // 
            // Button_EditLocation
            // 
            this.Button_EditLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_EditLocation.Location = new System.Drawing.Point(42, 744);
            this.Button_EditLocation.Name = "Button_EditLocation";
            this.Button_EditLocation.Size = new System.Drawing.Size(136, 51);
            this.Button_EditLocation.TabIndex = 24;
            this.Button_EditLocation.Text = "修改位置";
            this.Button_EditLocation.UseVisualStyleBackColor = true;
            this.Button_EditLocation.Click += new System.EventHandler(this.Button_EditLocation_Click);
            // 
            // Button_SelectAllTables
            // 
            this.Button_SelectAllTables.Location = new System.Drawing.Point(165, 86);
            this.Button_SelectAllTables.Name = "Button_SelectAllTables";
            this.Button_SelectAllTables.Size = new System.Drawing.Size(85, 32);
            this.Button_SelectAllTables.TabIndex = 9;
            this.Button_SelectAllTables.Text = "列表全选";
            this.Button_SelectAllTables.UseVisualStyleBackColor = true;
            this.Button_SelectAllTables.Click += new System.EventHandler(this.Button_SelectAllTables_Click);
            // 
            // TextBox_SaveLocation
            // 
            this.TextBox_SaveLocation.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox_SaveLocation.Location = new System.Drawing.Point(42, 694);
            this.TextBox_SaveLocation.Name = "TextBox_SaveLocation";
            this.TextBox_SaveLocation.ReadOnly = true;
            this.TextBox_SaveLocation.Size = new System.Drawing.Size(294, 27);
            this.TextBox_SaveLocation.TabIndex = 23;
            // 
            // CheckBox_UseSummary
            // 
            this.CheckBox_UseSummary.AutoSize = true;
            this.CheckBox_UseSummary.Checked = true;
            this.CheckBox_UseSummary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_UseSummary.Location = new System.Drawing.Point(250, 510);
            this.CheckBox_UseSummary.Name = "CheckBox_UseSummary";
            this.CheckBox_UseSummary.Size = new System.Drawing.Size(91, 24);
            this.CheckBox_UseSummary.TabIndex = 21;
            this.CheckBox_UseSummary.Text = "字段注释";
            this.CheckBox_UseSummary.UseVisualStyleBackColor = true;
            this.CheckBox_UseSummary.CheckedChanged += new System.EventHandler(this.CheckBox_UseSummary_CheckedChanged);
            // 
            // ComboBox_AccessModifier
            // 
            this.ComboBox_AccessModifier.FormattingEnabled = true;
            this.ComboBox_AccessModifier.Items.AddRange(new object[] {
            "public",
            "private",
            "protected"});
            this.ComboBox_AccessModifier.Location = new System.Drawing.Point(109, 454);
            this.ComboBox_AccessModifier.Name = "ComboBox_AccessModifier";
            this.ComboBox_AccessModifier.Size = new System.Drawing.Size(232, 28);
            this.ComboBox_AccessModifier.TabIndex = 19;
            this.ComboBox_AccessModifier.Text = "public";
            this.ComboBox_AccessModifier.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_AccessModifier_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "访问修饰符";
            // 
            // TextBox_NameSpace
            // 
            this.TextBox_NameSpace.Location = new System.Drawing.Point(109, 398);
            this.TextBox_NameSpace.Name = "TextBox_NameSpace";
            this.TextBox_NameSpace.Size = new System.Drawing.Size(232, 27);
            this.TextBox_NameSpace.TabIndex = 17;
            this.TextBox_NameSpace.Text = "Model";
            this.TextBox_NameSpace.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_NameSpace_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "namespace";
            // 
            // NumBox_TabSpace
            // 
            this.NumBox_TabSpace.Location = new System.Drawing.Point(109, 509);
            this.NumBox_TabSpace.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NumBox_TabSpace.Name = "NumBox_TabSpace";
            this.NumBox_TabSpace.Size = new System.Drawing.Size(95, 27);
            this.NumBox_TabSpace.TabIndex = 15;
            this.NumBox_TabSpace.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumBox_TabSpace.Validating += new System.ComponentModel.CancelEventHandler(this.NumBox_TabSpace_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "间隔";
            // 
            // TextBox_Using
            // 
            this.TextBox_Using.Location = new System.Drawing.Point(74, 148);
            this.TextBox_Using.Multiline = true;
            this.TextBox_Using.Name = "TextBox_Using";
            this.TextBox_Using.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Using.Size = new System.Drawing.Size(267, 212);
            this.TextBox_Using.TabIndex = 13;
            this.TextBox_Using.Text = "using System;";
            this.TextBox_Using.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Using_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "using";
            // 
            // ComboBox_Database
            // 
            this.ComboBox_Database.FormattingEnabled = true;
            this.ComboBox_Database.Location = new System.Drawing.Point(74, 14);
            this.ComboBox_Database.Name = "ComboBox_Database";
            this.ComboBox_Database.Size = new System.Drawing.Size(267, 28);
            this.ComboBox_Database.TabIndex = 8;
            this.ComboBox_Database.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Database_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "数据库";
            // 
            // SplitContainer_Main
            // 
            this.SplitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer_Main.Location = new System.Drawing.Point(0, 28);
            this.SplitContainer_Main.Name = "SplitContainer_Main";
            // 
            // SplitContainer_Main.Panel1
            // 
            this.SplitContainer_Main.Panel1.Controls.Add(this.CheckList_DataTable);
            this.SplitContainer_Main.Panel1MinSize = 250;
            // 
            // SplitContainer_Main.Panel2
            // 
            this.SplitContainer_Main.Panel2.Controls.Add(this.TextBox_Generated);
            this.SplitContainer_Main.Panel2.Controls.Add(this.Panel_Settings);
            this.SplitContainer_Main.Size = new System.Drawing.Size(1182, 825);
            this.SplitContainer_Main.SplitterDistance = 325;
            this.SplitContainer_Main.SplitterWidth = 5;
            this.SplitContainer_Main.TabIndex = 28;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File,
            this.ToolStripMenuItem_Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_File
            // 
            this.ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_NewConnection});
            this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            this.ToolStripMenuItem_File.Size = new System.Drawing.Size(53, 24);
            this.ToolStripMenuItem_File.Text = "文件";
            // 
            // ToolStripMenuItem_NewConnection
            // 
            this.ToolStripMenuItem_NewConnection.Name = "ToolStripMenuItem_NewConnection";
            this.ToolStripMenuItem_NewConnection.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItem_NewConnection.Text = "新建连接";
            this.ToolStripMenuItem_NewConnection.Click += new System.EventHandler(this.ToolStripMenuItem_NewConnection_Click);
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(53, 24);
            this.ToolStripMenuItem_Exit.Text = "退出";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.SplitContainer_Main);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "实体类生成工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Panel_Settings.ResumeLayout(false);
            this.Panel_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumBox_TabSpace)).EndInit();
            this.SplitContainer_Main.Panel1.ResumeLayout(false);
            this.SplitContainer_Main.Panel2.ResumeLayout(false);
            this.SplitContainer_Main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer_Main)).EndInit();
            this.SplitContainer_Main.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CheckList_DataTable;
        private System.Windows.Forms.Panel Panel_Settings;
        private System.Windows.Forms.TextBox TextBox_Generated;
        private System.Windows.Forms.ComboBox ComboBox_AccessModifier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBox_NameSpace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NumBox_TabSpace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBox_Using;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button_ClearTableSelect;
        private System.Windows.Forms.Button Button_ReverseTableSelect;
        private System.Windows.Forms.Button Button_SelectAllTables;
        private System.Windows.Forms.ComboBox ComboBox_Database;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_StartGenerate;
        private System.Windows.Forms.Button Button_EditLocation;
        private System.Windows.Forms.TextBox TextBox_SaveLocation;
        private System.Windows.Forms.CheckBox CheckBox_UseSummary;
        private System.Windows.Forms.Button Button_RefreshTableList;
        private System.Windows.Forms.SplitContainer SplitContainer_Main;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_NewConnection;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
        private System.Windows.Forms.Button Button_RefreshDatabaseList;
    }
}

