
namespace ModelTool.Forms
{
    partial class ConnectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_IP = new System.Windows.Forms.Label();
            this.TextBox_IP = new System.Windows.Forms.TextBox();
            this.TextBox_Account = new System.Windows.Forms.TextBox();
            this.Label_Account = new System.Windows.Forms.Label();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Button_Connect = new System.Windows.Forms.Button();
            this.Label_SqlType = new System.Windows.Forms.Label();
            this.ComboBox_SqlType = new System.Windows.Forms.ComboBox();
            this.CheckBox_Localhost = new System.Windows.Forms.CheckBox();
            this.TextBox_InstanceName = new System.Windows.Forms.TextBox();
            this.Label_InstanceName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_IP
            // 
            this.Label_IP.AutoSize = true;
            this.Label_IP.Location = new System.Drawing.Point(77, 49);
            this.Label_IP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_IP.Name = "Label_IP";
            this.Label_IP.Size = new System.Drawing.Size(31, 17);
            this.Label_IP.TabIndex = 3;
            this.Label_IP.Text = "IP：";
            // 
            // TextBox_IP
            // 
            this.TextBox_IP.Location = new System.Drawing.Point(112, 46);
            this.TextBox_IP.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_IP.MaxLength = 15;
            this.TextBox_IP.Name = "TextBox_IP";
            this.TextBox_IP.Size = new System.Drawing.Size(198, 23);
            this.TextBox_IP.TabIndex = 4;
            this.TextBox_IP.TextChanged += new System.EventHandler(this.TextBox_IP_TextChanged);
            // 
            // TextBox_Account
            // 
            this.TextBox_Account.Location = new System.Drawing.Point(112, 98);
            this.TextBox_Account.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_Account.Name = "TextBox_Account";
            this.TextBox_Account.Size = new System.Drawing.Size(198, 23);
            this.TextBox_Account.TabIndex = 8;
            this.TextBox_Account.TextChanged += new System.EventHandler(this.TextBox_Account_TextChanged);
            // 
            // Label_Account
            // 
            this.Label_Account.AutoSize = true;
            this.Label_Account.Location = new System.Drawing.Point(52, 101);
            this.Label_Account.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Account.Name = "Label_Account";
            this.Label_Account.Size = new System.Drawing.Size(56, 17);
            this.Label_Account.TabIndex = 7;
            this.Label_Account.Text = "用户名：";
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Location = new System.Drawing.Point(112, 124);
            this.TextBox_Password.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '*';
            this.TextBox_Password.Size = new System.Drawing.Size(198, 23);
            this.TextBox_Password.TabIndex = 10;
            this.TextBox_Password.TextChanged += new System.EventHandler(this.TextBox_Password_TextChanged);
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(64, 128);
            this.Label_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(44, 17);
            this.Label_Password.TabIndex = 9;
            this.Label_Password.Text = "密码：";
            // 
            // Button_Connect
            // 
            this.Button_Connect.Location = new System.Drawing.Point(137, 163);
            this.Button_Connect.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(68, 26);
            this.Button_Connect.TabIndex = 11;
            this.Button_Connect.Text = "建立连接";
            this.Button_Connect.UseVisualStyleBackColor = true;
            this.Button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // Label_SqlType
            // 
            this.Label_SqlType.AutoSize = true;
            this.Label_SqlType.Location = new System.Drawing.Point(28, 21);
            this.Label_SqlType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_SqlType.Name = "Label_SqlType";
            this.Label_SqlType.Size = new System.Drawing.Size(80, 17);
            this.Label_SqlType.TabIndex = 0;
            this.Label_SqlType.Text = "数据库类型：";
            // 
            // ComboBox_SqlType
            // 
            this.ComboBox_SqlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_SqlType.FormattingEnabled = true;
            this.ComboBox_SqlType.Items.AddRange(new object[] {
            "MSSQLServer",
            "MySQL",
            "Oracle"});
            this.ComboBox_SqlType.Location = new System.Drawing.Point(112, 18);
            this.ComboBox_SqlType.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox_SqlType.Name = "ComboBox_SqlType";
            this.ComboBox_SqlType.Size = new System.Drawing.Size(198, 25);
            this.ComboBox_SqlType.TabIndex = 1;
            this.ComboBox_SqlType.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SqlType_SelectedIndexChanged);
            // 
            // CheckBox_Localhost
            // 
            this.CheckBox_Localhost.AutoSize = true;
            this.CheckBox_Localhost.Location = new System.Drawing.Point(21, 48);
            this.CheckBox_Localhost.Name = "CheckBox_Localhost";
            this.CheckBox_Localhost.Size = new System.Drawing.Size(51, 21);
            this.CheckBox_Localhost.TabIndex = 2;
            this.CheckBox_Localhost.Text = "本地";
            this.CheckBox_Localhost.UseVisualStyleBackColor = true;
            this.CheckBox_Localhost.CheckedChanged += new System.EventHandler(this.CheckBox_Localhost_CheckedChanged);
            // 
            // TextBox_InstanceName
            // 
            this.TextBox_InstanceName.Location = new System.Drawing.Point(112, 72);
            this.TextBox_InstanceName.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_InstanceName.Name = "TextBox_InstanceName";
            this.TextBox_InstanceName.Size = new System.Drawing.Size(198, 23);
            this.TextBox_InstanceName.TabIndex = 6;
            this.TextBox_InstanceName.Text = "MSSQLSERVER";
            // 
            // Label_InstanceName
            // 
            this.Label_InstanceName.AutoSize = true;
            this.Label_InstanceName.Location = new System.Drawing.Point(40, 75);
            this.Label_InstanceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_InstanceName.Name = "Label_InstanceName";
            this.Label_InstanceName.Size = new System.Drawing.Size(68, 17);
            this.Label_InstanceName.TabIndex = 5;
            this.Label_InstanceName.Text = "实例名称：";
            // 
            // ConnectForm
            // 
            this.AcceptButton = this.Button_Connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(338, 199);
            this.Controls.Add(this.Label_InstanceName);
            this.Controls.Add(this.TextBox_InstanceName);
            this.Controls.Add(this.CheckBox_Localhost);
            this.Controls.Add(this.ComboBox_SqlType);
            this.Controls.Add(this.Label_SqlType);
            this.Controls.Add(this.Button_Connect);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.TextBox_Account);
            this.Controls.Add(this.Label_Account);
            this.Controls.Add(this.TextBox_IP);
            this.Controls.Add(this.Label_IP);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::ModelTool.Properties.Resources.Logo;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新建连接";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_IP;
        private System.Windows.Forms.TextBox TextBox_IP;
        private System.Windows.Forms.TextBox TextBox_Account;
        private System.Windows.Forms.Label Label_Account;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.Button Button_Connect;
        private System.Windows.Forms.Label Label_SqlType;
        private System.Windows.Forms.ComboBox ComboBox_SqlType;
        private System.Windows.Forms.CheckBox CheckBox_Localhost;
        private System.Windows.Forms.TextBox TextBox_InstanceName;
        private System.Windows.Forms.Label Label_InstanceName;
    }
}