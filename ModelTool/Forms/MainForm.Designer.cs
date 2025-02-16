﻿namespace ModelTool.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CheckedListBox_DataTable = new System.Windows.Forms.CheckedListBox();
            this.TextBox_Generated = new System.Windows.Forms.TextBox();
            this.Panel_Settings = new System.Windows.Forms.Panel();
            this.TextBox_Inherit = new System.Windows.Forms.TextBox();
            this.Label_Inherit = new System.Windows.Forms.Label();
            this.Label_ExportPath = new System.Windows.Forms.Label();
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
            this.Label_Privacy = new System.Windows.Forms.Label();
            this.TextBox_NameSpace = new System.Windows.Forms.TextBox();
            this.Label_NameSpace = new System.Windows.Forms.Label();
            this.NumBox_TabSpace = new System.Windows.Forms.NumericUpDown();
            this.Label_TabSpace = new System.Windows.Forms.Label();
            this.TextBox_Using = new System.Windows.Forms.TextBox();
            this.Label_Using = new System.Windows.Forms.Label();
            this.ComboBox_Database = new System.Windows.Forms.ComboBox();
            this.Label_Database = new System.Windows.Forms.Label();
            this.SplitContainer_Main = new System.Windows.Forms.SplitContainer();
            this.MenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_NewConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_EnableSQLSugarDefaultSupport = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumBox_TabSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer_Main)).BeginInit();
            this.SplitContainer_Main.Panel1.SuspendLayout();
            this.SplitContainer_Main.Panel2.SuspendLayout();
            this.SplitContainer_Main.SuspendLayout();
            this.MenuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckedListBox_DataTable
            // 
            this.CheckedListBox_DataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckedListBox_DataTable.FormattingEnabled = true;
            this.CheckedListBox_DataTable.Location = new System.Drawing.Point(0, 0);
            this.CheckedListBox_DataTable.Margin = new System.Windows.Forms.Padding(2);
            this.CheckedListBox_DataTable.Name = "CheckedListBox_DataTable";
            this.CheckedListBox_DataTable.Size = new System.Drawing.Size(250, 670);
            this.CheckedListBox_DataTable.TabIndex = 0;
            this.CheckedListBox_DataTable.SelectedIndexChanged += new System.EventHandler(this.CheckList_DataTable_SelectedIndexChanged);
            // 
            // TextBox_Generated
            // 
            this.TextBox_Generated.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox_Generated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Generated.Location = new System.Drawing.Point(297, 0);
            this.TextBox_Generated.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_Generated.Multiline = true;
            this.TextBox_Generated.Name = "TextBox_Generated";
            this.TextBox_Generated.ReadOnly = true;
            this.TextBox_Generated.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox_Generated.Size = new System.Drawing.Size(583, 670);
            this.TextBox_Generated.TabIndex = 1;
            this.TextBox_Generated.Text = resources.GetString("TextBox_Generated.Text");
            // 
            // Panel_Settings
            // 
            this.Panel_Settings.Controls.Add(this.TextBox_Inherit);
            this.Panel_Settings.Controls.Add(this.Label_Inherit);
            this.Panel_Settings.Controls.Add(this.Label_ExportPath);
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
            this.Panel_Settings.Controls.Add(this.Label_Privacy);
            this.Panel_Settings.Controls.Add(this.TextBox_NameSpace);
            this.Panel_Settings.Controls.Add(this.Label_NameSpace);
            this.Panel_Settings.Controls.Add(this.NumBox_TabSpace);
            this.Panel_Settings.Controls.Add(this.Label_TabSpace);
            this.Panel_Settings.Controls.Add(this.TextBox_Using);
            this.Panel_Settings.Controls.Add(this.Label_Using);
            this.Panel_Settings.Controls.Add(this.ComboBox_Database);
            this.Panel_Settings.Controls.Add(this.Label_Database);
            this.Panel_Settings.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Settings.Location = new System.Drawing.Point(0, 0);
            this.Panel_Settings.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_Settings.Name = "Panel_Settings";
            this.Panel_Settings.Size = new System.Drawing.Size(297, 670);
            this.Panel_Settings.TabIndex = 0;
            // 
            // TextBox_Inherit
            // 
            this.TextBox_Inherit.Location = new System.Drawing.Point(87, 400);
            this.TextBox_Inherit.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_Inherit.Name = "TextBox_Inherit";
            this.TextBox_Inherit.Size = new System.Drawing.Size(186, 23);
            this.TextBox_Inherit.TabIndex = 14;
            this.TextBox_Inherit.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Inherit_Validating);
            // 
            // Label_Inherit
            // 
            this.Label_Inherit.AutoSize = true;
            this.Label_Inherit.Location = new System.Drawing.Point(10, 403);
            this.Label_Inherit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Inherit.Name = "Label_Inherit";
            this.Label_Inherit.Size = new System.Drawing.Size(44, 17);
            this.Label_Inherit.TabIndex = 13;
            this.Label_Inherit.Text = "继承自";
            // 
            // Label_ExportPath
            // 
            this.Label_ExportPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_ExportPath.AutoSize = true;
            this.Label_ExportPath.Location = new System.Drawing.Point(31, 548);
            this.Label_ExportPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_ExportPath.Name = "Label_ExportPath";
            this.Label_ExportPath.Size = new System.Drawing.Size(68, 17);
            this.Label_ExportPath.TabIndex = 18;
            this.Label_ExportPath.Text = "输出位置：";
            // 
            // Button_RefreshDatabaseList
            // 
            this.Button_RefreshDatabaseList.Location = new System.Drawing.Point(169, 41);
            this.Button_RefreshDatabaseList.Margin = new System.Windows.Forms.Padding(2);
            this.Button_RefreshDatabaseList.Name = "Button_RefreshDatabaseList";
            this.Button_RefreshDatabaseList.Size = new System.Drawing.Size(104, 26);
            this.Button_RefreshDatabaseList.TabIndex = 3;
            this.Button_RefreshDatabaseList.Text = "刷新库列表";
            this.Button_RefreshDatabaseList.UseVisualStyleBackColor = true;
            this.Button_RefreshDatabaseList.Click += new System.EventHandler(this.Button_RefreshDatabaseList_Click);
            // 
            // Button_RefreshTableList
            // 
            this.Button_RefreshTableList.Location = new System.Drawing.Point(59, 41);
            this.Button_RefreshTableList.Margin = new System.Windows.Forms.Padding(2);
            this.Button_RefreshTableList.Name = "Button_RefreshTableList";
            this.Button_RefreshTableList.Size = new System.Drawing.Size(104, 26);
            this.Button_RefreshTableList.TabIndex = 2;
            this.Button_RefreshTableList.Text = "刷新表列表";
            this.Button_RefreshTableList.UseVisualStyleBackColor = true;
            this.Button_RefreshTableList.Click += new System.EventHandler(this.Button_RefreshTableList_Click);
            // 
            // Button_StartGenerate
            // 
            this.Button_StartGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_StartGenerate.Location = new System.Drawing.Point(160, 605);
            this.Button_StartGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.Button_StartGenerate.Name = "Button_StartGenerate";
            this.Button_StartGenerate.Size = new System.Drawing.Size(109, 41);
            this.Button_StartGenerate.TabIndex = 21;
            this.Button_StartGenerate.Text = "开始生成";
            this.Button_StartGenerate.UseVisualStyleBackColor = true;
            this.Button_StartGenerate.Click += new System.EventHandler(this.Button_StartGenerate_Click);
            // 
            // Button_ClearTableSelect
            // 
            this.Button_ClearTableSelect.Location = new System.Drawing.Point(205, 72);
            this.Button_ClearTableSelect.Margin = new System.Windows.Forms.Padding(2);
            this.Button_ClearTableSelect.Name = "Button_ClearTableSelect";
            this.Button_ClearTableSelect.Size = new System.Drawing.Size(68, 26);
            this.Button_ClearTableSelect.TabIndex = 6;
            this.Button_ClearTableSelect.Text = "重新选择";
            this.Button_ClearTableSelect.UseVisualStyleBackColor = true;
            this.Button_ClearTableSelect.Click += new System.EventHandler(this.Button_ClearTableSelect_Click);
            // 
            // Button_ReverseTableSelect
            // 
            this.Button_ReverseTableSelect.Location = new System.Drawing.Point(132, 72);
            this.Button_ReverseTableSelect.Margin = new System.Windows.Forms.Padding(2);
            this.Button_ReverseTableSelect.Name = "Button_ReverseTableSelect";
            this.Button_ReverseTableSelect.Size = new System.Drawing.Size(68, 26);
            this.Button_ReverseTableSelect.TabIndex = 5;
            this.Button_ReverseTableSelect.Text = "列表反选";
            this.Button_ReverseTableSelect.UseVisualStyleBackColor = true;
            this.Button_ReverseTableSelect.Click += new System.EventHandler(this.Button_ReverseTableSelect_Click);
            // 
            // Button_EditLocation
            // 
            this.Button_EditLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_EditLocation.Location = new System.Drawing.Point(34, 605);
            this.Button_EditLocation.Margin = new System.Windows.Forms.Padding(2);
            this.Button_EditLocation.Name = "Button_EditLocation";
            this.Button_EditLocation.Size = new System.Drawing.Size(109, 41);
            this.Button_EditLocation.TabIndex = 20;
            this.Button_EditLocation.Text = "修改位置";
            this.Button_EditLocation.UseVisualStyleBackColor = true;
            this.Button_EditLocation.Click += new System.EventHandler(this.Button_EditLocation_Click);
            // 
            // Button_SelectAllTables
            // 
            this.Button_SelectAllTables.Location = new System.Drawing.Point(59, 72);
            this.Button_SelectAllTables.Margin = new System.Windows.Forms.Padding(2);
            this.Button_SelectAllTables.Name = "Button_SelectAllTables";
            this.Button_SelectAllTables.Size = new System.Drawing.Size(68, 26);
            this.Button_SelectAllTables.TabIndex = 4;
            this.Button_SelectAllTables.Text = "列表全选";
            this.Button_SelectAllTables.UseVisualStyleBackColor = true;
            this.Button_SelectAllTables.Click += new System.EventHandler(this.Button_SelectAllTables_Click);
            // 
            // TextBox_SaveLocation
            // 
            this.TextBox_SaveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBox_SaveLocation.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox_SaveLocation.Location = new System.Drawing.Point(34, 567);
            this.TextBox_SaveLocation.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_SaveLocation.Name = "TextBox_SaveLocation";
            this.TextBox_SaveLocation.ReadOnly = true;
            this.TextBox_SaveLocation.Size = new System.Drawing.Size(236, 23);
            this.TextBox_SaveLocation.TabIndex = 19;
            // 
            // CheckBox_UseSummary
            // 
            this.CheckBox_UseSummary.AutoSize = true;
            this.CheckBox_UseSummary.Checked = true;
            this.CheckBox_UseSummary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_UseSummary.Location = new System.Drawing.Point(200, 444);
            this.CheckBox_UseSummary.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBox_UseSummary.Name = "CheckBox_UseSummary";
            this.CheckBox_UseSummary.Size = new System.Drawing.Size(75, 21);
            this.CheckBox_UseSummary.TabIndex = 17;
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
            this.ComboBox_AccessModifier.Location = new System.Drawing.Point(87, 357);
            this.ComboBox_AccessModifier.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox_AccessModifier.Name = "ComboBox_AccessModifier";
            this.ComboBox_AccessModifier.Size = new System.Drawing.Size(186, 25);
            this.ComboBox_AccessModifier.TabIndex = 12;
            this.ComboBox_AccessModifier.Text = "public";
            this.ComboBox_AccessModifier.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_AccessModifier_Validating);
            // 
            // Label_Privacy
            // 
            this.Label_Privacy.AutoSize = true;
            this.Label_Privacy.Location = new System.Drawing.Point(11, 360);
            this.Label_Privacy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Privacy.Name = "Label_Privacy";
            this.Label_Privacy.Size = new System.Drawing.Size(68, 17);
            this.Label_Privacy.TabIndex = 11;
            this.Label_Privacy.Text = "访问修饰符";
            // 
            // TextBox_NameSpace
            // 
            this.TextBox_NameSpace.Location = new System.Drawing.Point(87, 313);
            this.TextBox_NameSpace.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_NameSpace.Name = "TextBox_NameSpace";
            this.TextBox_NameSpace.Size = new System.Drawing.Size(186, 23);
            this.TextBox_NameSpace.TabIndex = 10;
            this.TextBox_NameSpace.Text = "Model";
            this.TextBox_NameSpace.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_NameSpace_Validating);
            // 
            // Label_NameSpace
            // 
            this.Label_NameSpace.AutoSize = true;
            this.Label_NameSpace.Location = new System.Drawing.Point(10, 316);
            this.Label_NameSpace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_NameSpace.Name = "Label_NameSpace";
            this.Label_NameSpace.Size = new System.Drawing.Size(74, 17);
            this.Label_NameSpace.TabIndex = 9;
            this.Label_NameSpace.Text = "namespace";
            // 
            // NumBox_TabSpace
            // 
            this.NumBox_TabSpace.Location = new System.Drawing.Point(87, 443);
            this.NumBox_TabSpace.Margin = new System.Windows.Forms.Padding(2);
            this.NumBox_TabSpace.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NumBox_TabSpace.Name = "NumBox_TabSpace";
            this.NumBox_TabSpace.Size = new System.Drawing.Size(76, 23);
            this.NumBox_TabSpace.TabIndex = 16;
            this.NumBox_TabSpace.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumBox_TabSpace.Validating += new System.ComponentModel.CancelEventHandler(this.NumBox_TabSpace_Validating);
            // 
            // Label_TabSpace
            // 
            this.Label_TabSpace.AutoSize = true;
            this.Label_TabSpace.Location = new System.Drawing.Point(10, 445);
            this.Label_TabSpace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_TabSpace.Name = "Label_TabSpace";
            this.Label_TabSpace.Size = new System.Drawing.Size(32, 17);
            this.Label_TabSpace.TabIndex = 15;
            this.Label_TabSpace.Text = "间隔";
            // 
            // TextBox_Using
            // 
            this.TextBox_Using.Location = new System.Drawing.Point(59, 118);
            this.TextBox_Using.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_Using.Multiline = true;
            this.TextBox_Using.Name = "TextBox_Using";
            this.TextBox_Using.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Using.Size = new System.Drawing.Size(214, 170);
            this.TextBox_Using.TabIndex = 8;
            this.TextBox_Using.Text = "using System;";
            this.TextBox_Using.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Using_Validating);
            // 
            // Label_Using
            // 
            this.Label_Using.AutoSize = true;
            this.Label_Using.Location = new System.Drawing.Point(10, 121);
            this.Label_Using.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Using.Name = "Label_Using";
            this.Label_Using.Size = new System.Drawing.Size(39, 17);
            this.Label_Using.TabIndex = 7;
            this.Label_Using.Text = "using";
            // 
            // ComboBox_Database
            // 
            this.ComboBox_Database.FormattingEnabled = true;
            this.ComboBox_Database.Location = new System.Drawing.Point(59, 11);
            this.ComboBox_Database.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox_Database.Name = "ComboBox_Database";
            this.ComboBox_Database.Size = new System.Drawing.Size(214, 25);
            this.ComboBox_Database.TabIndex = 1;
            this.ComboBox_Database.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Database_SelectedIndexChanged);
            // 
            // Label_Database
            // 
            this.Label_Database.AutoSize = true;
            this.Label_Database.Location = new System.Drawing.Point(11, 14);
            this.Label_Database.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Database.Name = "Label_Database";
            this.Label_Database.Size = new System.Drawing.Size(44, 17);
            this.Label_Database.TabIndex = 0;
            this.Label_Database.Text = "数据库";
            // 
            // SplitContainer_Main
            // 
            this.SplitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer_Main.Location = new System.Drawing.Point(0, 25);
            this.SplitContainer_Main.Margin = new System.Windows.Forms.Padding(2);
            this.SplitContainer_Main.Name = "SplitContainer_Main";
            // 
            // SplitContainer_Main.Panel1
            // 
            this.SplitContainer_Main.Panel1.Controls.Add(this.CheckedListBox_DataTable);
            this.SplitContainer_Main.Panel1MinSize = 250;
            // 
            // SplitContainer_Main.Panel2
            // 
            this.SplitContainer_Main.Panel2.Controls.Add(this.TextBox_Generated);
            this.SplitContainer_Main.Panel2.Controls.Add(this.Panel_Settings);
            this.SplitContainer_Main.Size = new System.Drawing.Size(1134, 670);
            this.SplitContainer_Main.SplitterDistance = 250;
            this.SplitContainer_Main.TabIndex = 1;
            // 
            // MenuStrip_Main
            // 
            this.MenuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File,
            this.ToolStripMenuItem_Exit});
            this.MenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Main.Name = "MenuStrip_Main";
            this.MenuStrip_Main.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MenuStrip_Main.Size = new System.Drawing.Size(1134, 25);
            this.MenuStrip_Main.TabIndex = 0;
            this.MenuStrip_Main.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_File
            // 
            this.ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_NewConnection,
            this.toolStripSeparator1,
            this.ToolStripMenuItem_EnableSQLSugarDefaultSupport});
            this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            this.ToolStripMenuItem_File.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem_File.Text = "文件";
            // 
            // ToolStripMenuItem_NewConnection
            // 
            this.ToolStripMenuItem_NewConnection.Name = "ToolStripMenuItem_NewConnection";
            this.ToolStripMenuItem_NewConnection.Size = new System.Drawing.Size(205, 22);
            this.ToolStripMenuItem_NewConnection.Text = "新建连接";
            this.ToolStripMenuItem_NewConnection.Click += new System.EventHandler(this.ToolStripMenuItem_NewConnection_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // ToolStripMenuItem_EnableSQLSugarDefaultSupport
            // 
            this.ToolStripMenuItem_EnableSQLSugarDefaultSupport.CheckOnClick = true;
            this.ToolStripMenuItem_EnableSQLSugarDefaultSupport.Name = "ToolStripMenuItem_EnableSQLSugarDefaultSupport";
            this.ToolStripMenuItem_EnableSQLSugarDefaultSupport.Size = new System.Drawing.Size(205, 22);
            this.ToolStripMenuItem_EnableSQLSugarDefaultSupport.Text = "启用SQLSugar默认支持";
            this.ToolStripMenuItem_EnableSQLSugarDefaultSupport.Click += new System.EventHandler(this.ToolStripMenuItem_EnableSQLSugarDefaultSupport_Click);
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem_Exit.Text = "退出";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1134, 695);
            this.Controls.Add(this.SplitContainer_Main);
            this.Controls.Add(this.MenuStrip_Main);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip_Main;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(985, 700);
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
            this.MenuStrip_Main.ResumeLayout(false);
            this.MenuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CheckedListBox_DataTable;
        private System.Windows.Forms.Panel Panel_Settings;
        private System.Windows.Forms.TextBox TextBox_Generated;
        private System.Windows.Forms.ComboBox ComboBox_AccessModifier;
        private System.Windows.Forms.Label Label_Privacy;
        private System.Windows.Forms.TextBox TextBox_NameSpace;
        private System.Windows.Forms.Label Label_NameSpace;
        private System.Windows.Forms.NumericUpDown NumBox_TabSpace;
        private System.Windows.Forms.Label Label_TabSpace;
        private System.Windows.Forms.TextBox TextBox_Using;
        private System.Windows.Forms.Label Label_Using;
        private System.Windows.Forms.Button Button_ClearTableSelect;
        private System.Windows.Forms.Button Button_ReverseTableSelect;
        private System.Windows.Forms.Button Button_SelectAllTables;
        private System.Windows.Forms.ComboBox ComboBox_Database;
        private System.Windows.Forms.Label Label_Database;
        private System.Windows.Forms.Button Button_StartGenerate;
        private System.Windows.Forms.Button Button_EditLocation;
        private System.Windows.Forms.TextBox TextBox_SaveLocation;
        private System.Windows.Forms.CheckBox CheckBox_UseSummary;
        private System.Windows.Forms.Button Button_RefreshTableList;
        private System.Windows.Forms.SplitContainer SplitContainer_Main;
        private System.Windows.Forms.MenuStrip MenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_NewConnection;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
        private System.Windows.Forms.Button Button_RefreshDatabaseList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_EnableSQLSugarDefaultSupport;
        private System.Windows.Forms.TextBox TextBox_Inherit;
        private System.Windows.Forms.Label Label_Inherit;
        private System.Windows.Forms.Label Label_ExportPath;
    }
}

