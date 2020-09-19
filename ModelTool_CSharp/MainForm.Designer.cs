namespace ModelTool_CSharp
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
            this.dataTableCheckList = new System.Windows.Forms.CheckedListBox();
            this.GeneratedText = new System.Windows.Forms.TextBox();
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.refreshTableList_button = new System.Windows.Forms.Button();
            this.ip_box = new System.Windows.Forms.TextBox();
            this.startGenerate_button = new System.Windows.Forms.Button();
            this.editLocation_button = new System.Windows.Forms.Button();
            this.saveLocation_box = new System.Windows.Forms.TextBox();
            this.useSummary_checkBox = new System.Windows.Forms.CheckBox();
            this.accessModifier_comboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.namespace_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.space_numBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.using_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableClearSelect_button = new System.Windows.Forms.Button();
            this.tableReverseSelect_button = new System.Windows.Forms.Button();
            this.tableSelectAll_button = new System.Windows.Forms.Button();
            this.database_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.connect_button = new System.Windows.Forms.Button();
            this.password_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.account_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.space_numBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableCheckList
            // 
            this.dataTableCheckList.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataTableCheckList.FormattingEnabled = true;
            this.dataTableCheckList.Location = new System.Drawing.Point(0, 0);
            this.dataTableCheckList.Name = "dataTableCheckList";
            this.dataTableCheckList.Size = new System.Drawing.Size(235, 681);
            this.dataTableCheckList.TabIndex = 0;
            this.dataTableCheckList.SelectedIndexChanged += new System.EventHandler(this.dataTableCheckList_SelectedIndexChanged);
            // 
            // GeneratedText
            // 
            this.GeneratedText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneratedText.BackColor = System.Drawing.SystemColors.Window;
            this.GeneratedText.Location = new System.Drawing.Point(235, 0);
            this.GeneratedText.Multiline = true;
            this.GeneratedText.Name = "GeneratedText";
            this.GeneratedText.ReadOnly = true;
            this.GeneratedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GeneratedText.Size = new System.Drawing.Size(668, 414);
            this.GeneratedText.TabIndex = 1;
            // 
            // SettingPanel
            // 
            this.SettingPanel.Controls.Add(this.refreshTableList_button);
            this.SettingPanel.Controls.Add(this.ip_box);
            this.SettingPanel.Controls.Add(this.startGenerate_button);
            this.SettingPanel.Controls.Add(this.editLocation_button);
            this.SettingPanel.Controls.Add(this.saveLocation_box);
            this.SettingPanel.Controls.Add(this.useSummary_checkBox);
            this.SettingPanel.Controls.Add(this.accessModifier_comboBox);
            this.SettingPanel.Controls.Add(this.label8);
            this.SettingPanel.Controls.Add(this.namespace_box);
            this.SettingPanel.Controls.Add(this.label7);
            this.SettingPanel.Controls.Add(this.space_numBox);
            this.SettingPanel.Controls.Add(this.label6);
            this.SettingPanel.Controls.Add(this.using_box);
            this.SettingPanel.Controls.Add(this.label5);
            this.SettingPanel.Controls.Add(this.tableClearSelect_button);
            this.SettingPanel.Controls.Add(this.tableReverseSelect_button);
            this.SettingPanel.Controls.Add(this.tableSelectAll_button);
            this.SettingPanel.Controls.Add(this.database_comboBox);
            this.SettingPanel.Controls.Add(this.label4);
            this.SettingPanel.Controls.Add(this.connect_button);
            this.SettingPanel.Controls.Add(this.password_box);
            this.SettingPanel.Controls.Add(this.label3);
            this.SettingPanel.Controls.Add(this.account_box);
            this.SettingPanel.Controls.Add(this.label2);
            this.SettingPanel.Controls.Add(this.label1);
            this.SettingPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingPanel.Location = new System.Drawing.Point(235, 420);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.Size = new System.Drawing.Size(668, 261);
            this.SettingPanel.TabIndex = 2;
            // 
            // refreshTableList_button
            // 
            this.refreshTableList_button.Location = new System.Drawing.Point(235, 50);
            this.refreshTableList_button.Name = "refreshTableList_button";
            this.refreshTableList_button.Size = new System.Drawing.Size(75, 23);
            this.refreshTableList_button.TabIndex = 27;
            this.refreshTableList_button.Text = "刷新列表";
            this.refreshTableList_button.UseVisualStyleBackColor = true;
            this.refreshTableList_button.Click += new System.EventHandler(this.refreshTableList_button_Click);
            // 
            // ip_box
            // 
            this.ip_box.Location = new System.Drawing.Point(47, 12);
            this.ip_box.Name = "ip_box";
            this.ip_box.Size = new System.Drawing.Size(110, 21);
            this.ip_box.TabIndex = 26;
            // 
            // startGenerate_button
            // 
            this.startGenerate_button.Location = new System.Drawing.Point(504, 198);
            this.startGenerate_button.Name = "startGenerate_button";
            this.startGenerate_button.Size = new System.Drawing.Size(136, 51);
            this.startGenerate_button.TabIndex = 25;
            this.startGenerate_button.Text = "开始生成";
            this.startGenerate_button.UseVisualStyleBackColor = true;
            this.startGenerate_button.Click += new System.EventHandler(this.startGenerate_button_Click);
            // 
            // editLocation_button
            // 
            this.editLocation_button.Location = new System.Drawing.Point(346, 198);
            this.editLocation_button.Name = "editLocation_button";
            this.editLocation_button.Size = new System.Drawing.Size(136, 51);
            this.editLocation_button.TabIndex = 24;
            this.editLocation_button.Text = "修改位置";
            this.editLocation_button.UseVisualStyleBackColor = true;
            this.editLocation_button.Click += new System.EventHandler(this.editLocation_button_Click);
            // 
            // saveLocation_box
            // 
            this.saveLocation_box.BackColor = System.Drawing.SystemColors.Window;
            this.saveLocation_box.Location = new System.Drawing.Point(346, 171);
            this.saveLocation_box.Name = "saveLocation_box";
            this.saveLocation_box.ReadOnly = true;
            this.saveLocation_box.Size = new System.Drawing.Size(294, 21);
            this.saveLocation_box.TabIndex = 23;
            // 
            // useSummary_checkBox
            // 
            this.useSummary_checkBox.AutoSize = true;
            this.useSummary_checkBox.Checked = true;
            this.useSummary_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useSummary_checkBox.Location = new System.Drawing.Point(568, 145);
            this.useSummary_checkBox.Name = "useSummary_checkBox";
            this.useSummary_checkBox.Size = new System.Drawing.Size(72, 16);
            this.useSummary_checkBox.TabIndex = 21;
            this.useSummary_checkBox.Text = "字段注释";
            this.useSummary_checkBox.UseVisualStyleBackColor = true;
            this.useSummary_checkBox.CheckedChanged += new System.EventHandler(this.useSummary_checkBox_CheckedChanged);
            // 
            // accessModifier_comboBox
            // 
            this.accessModifier_comboBox.FormattingEnabled = true;
            this.accessModifier_comboBox.Items.AddRange(new object[] {
            "public",
            "private",
            "protected"});
            this.accessModifier_comboBox.Location = new System.Drawing.Point(427, 118);
            this.accessModifier_comboBox.Name = "accessModifier_comboBox";
            this.accessModifier_comboBox.Size = new System.Drawing.Size(213, 20);
            this.accessModifier_comboBox.TabIndex = 19;
            this.accessModifier_comboBox.Text = "public";
            this.accessModifier_comboBox.Validating += new System.ComponentModel.CancelEventHandler(this.accessModifier_comboBox_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "访问修饰符";
            // 
            // namespace_box
            // 
            this.namespace_box.Location = new System.Drawing.Point(427, 91);
            this.namespace_box.Name = "namespace_box";
            this.namespace_box.Size = new System.Drawing.Size(213, 21);
            this.namespace_box.TabIndex = 17;
            this.namespace_box.Text = "Model";
            this.namespace_box.Validating += new System.ComponentModel.CancelEventHandler(this.namespace_box_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "namespace";
            // 
            // space_numBox
            // 
            this.space_numBox.Location = new System.Drawing.Point(427, 144);
            this.space_numBox.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.space_numBox.Name = "space_numBox";
            this.space_numBox.Size = new System.Drawing.Size(55, 21);
            this.space_numBox.TabIndex = 15;
            this.space_numBox.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.space_numBox.Validating += new System.ComponentModel.CancelEventHandler(this.space_numBox_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "间隔";
            // 
            // using_box
            // 
            this.using_box.Location = new System.Drawing.Point(72, 91);
            this.using_box.Multiline = true;
            this.using_box.Name = "using_box";
            this.using_box.Size = new System.Drawing.Size(238, 158);
            this.using_box.TabIndex = 13;
            this.using_box.Text = "using System;";
            this.using_box.Validating += new System.ComponentModel.CancelEventHandler(this.using_box_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "using";
            // 
            // tableClearSelect_button
            // 
            this.tableClearSelect_button.Location = new System.Drawing.Point(565, 50);
            this.tableClearSelect_button.Name = "tableClearSelect_button";
            this.tableClearSelect_button.Size = new System.Drawing.Size(75, 23);
            this.tableClearSelect_button.TabIndex = 11;
            this.tableClearSelect_button.Text = "清除选择";
            this.tableClearSelect_button.UseVisualStyleBackColor = true;
            this.tableClearSelect_button.Click += new System.EventHandler(this.tableClearSelect_button_Click);
            // 
            // tableReverseSelect_button
            // 
            this.tableReverseSelect_button.Location = new System.Drawing.Point(458, 50);
            this.tableReverseSelect_button.Name = "tableReverseSelect_button";
            this.tableReverseSelect_button.Size = new System.Drawing.Size(75, 23);
            this.tableReverseSelect_button.TabIndex = 10;
            this.tableReverseSelect_button.Text = "反选表单";
            this.tableReverseSelect_button.UseVisualStyleBackColor = true;
            this.tableReverseSelect_button.Click += new System.EventHandler(this.tableReverseSelect_button_Click);
            // 
            // tableSelectAll_button
            // 
            this.tableSelectAll_button.Location = new System.Drawing.Point(346, 50);
            this.tableSelectAll_button.Name = "tableSelectAll_button";
            this.tableSelectAll_button.Size = new System.Drawing.Size(75, 23);
            this.tableSelectAll_button.TabIndex = 9;
            this.tableSelectAll_button.Text = "表单全选";
            this.tableSelectAll_button.UseVisualStyleBackColor = true;
            this.tableSelectAll_button.Click += new System.EventHandler(this.tableSelectAll_button_Click);
            // 
            // database_comboBox
            // 
            this.database_comboBox.FormattingEnabled = true;
            this.database_comboBox.Location = new System.Drawing.Point(72, 52);
            this.database_comboBox.Name = "database_comboBox";
            this.database_comboBox.Size = new System.Drawing.Size(157, 20);
            this.database_comboBox.TabIndex = 8;
            this.database_comboBox.SelectedIndexChanged += new System.EventHandler(this.database_comboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "数据库";
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(565, 12);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(75, 23);
            this.connect_button.TabIndex = 6;
            this.connect_button.Text = "连接";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(393, 12);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(137, 21);
            this.password_box.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "密码:";
            // 
            // account_box
            // 
            this.account_box.Location = new System.Drawing.Point(226, 12);
            this.account_box.Name = "account_box";
            this.account_box.Size = new System.Drawing.Size(110, 21);
            this.account_box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "登录名:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 681);
            this.Controls.Add(this.SettingPanel);
            this.Controls.Add(this.GeneratedText);
            this.Controls.Add(this.dataTableCheckList);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "实体类生成工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SettingPanel.ResumeLayout(false);
            this.SettingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.space_numBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox dataTableCheckList;
        private System.Windows.Forms.Panel SettingPanel;
        private System.Windows.Forms.TextBox GeneratedText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox accessModifier_comboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox namespace_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown space_numBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox using_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tableClearSelect_button;
        private System.Windows.Forms.Button tableReverseSelect_button;
        private System.Windows.Forms.Button tableSelectAll_button;
        private System.Windows.Forms.ComboBox database_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox account_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startGenerate_button;
        private System.Windows.Forms.Button editLocation_button;
        private System.Windows.Forms.TextBox saveLocation_box;
        private System.Windows.Forms.CheckBox useSummary_checkBox;
        private System.Windows.Forms.TextBox ip_box;
        private System.Windows.Forms.Button refreshTableList_button;
    }
}

