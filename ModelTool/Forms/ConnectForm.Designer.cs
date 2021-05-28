
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
            this.SuspendLayout();
            // 
            // Label_IP
            // 
            this.Label_IP.AutoSize = true;
            this.Label_IP.Location = new System.Drawing.Point(91, 60);
            this.Label_IP.Name = "Label_IP";
            this.Label_IP.Size = new System.Drawing.Size(37, 20);
            this.Label_IP.TabIndex = 2;
            this.Label_IP.Text = "IP：";
            // 
            // TextBox_IP
            // 
            this.TextBox_IP.Location = new System.Drawing.Point(134, 57);
            this.TextBox_IP.MaxLength = 15;
            this.TextBox_IP.Name = "TextBox_IP";
            this.TextBox_IP.Size = new System.Drawing.Size(247, 27);
            this.TextBox_IP.TabIndex = 3;
            this.TextBox_IP.TextChanged += new System.EventHandler(this.TextBox_IP_TextChanged);
            // 
            // TextBox_Account
            // 
            this.TextBox_Account.Location = new System.Drawing.Point(134, 90);
            this.TextBox_Account.Name = "TextBox_Account";
            this.TextBox_Account.Size = new System.Drawing.Size(247, 27);
            this.TextBox_Account.TabIndex = 5;
            this.TextBox_Account.TextChanged += new System.EventHandler(this.TextBox_Account_TextChanged);
            // 
            // Label_Account
            // 
            this.Label_Account.AutoSize = true;
            this.Label_Account.Location = new System.Drawing.Point(59, 93);
            this.Label_Account.Name = "Label_Account";
            this.Label_Account.Size = new System.Drawing.Size(69, 20);
            this.Label_Account.TabIndex = 4;
            this.Label_Account.Text = "用户名：";
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Location = new System.Drawing.Point(134, 123);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '*';
            this.TextBox_Password.Size = new System.Drawing.Size(247, 27);
            this.TextBox_Password.TabIndex = 7;
            this.TextBox_Password.TextChanged += new System.EventHandler(this.TextBox_Password_TextChanged);
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(74, 126);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(54, 20);
            this.Label_Password.TabIndex = 6;
            this.Label_Password.Text = "密码：";
            // 
            // Button_Connect
            // 
            this.Button_Connect.Location = new System.Drawing.Point(171, 169);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(85, 32);
            this.Button_Connect.TabIndex = 8;
            this.Button_Connect.Text = "建立连接";
            this.Button_Connect.UseVisualStyleBackColor = true;
            this.Button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // Label_SqlType
            // 
            this.Label_SqlType.AutoSize = true;
            this.Label_SqlType.Location = new System.Drawing.Point(29, 26);
            this.Label_SqlType.Name = "Label_SqlType";
            this.Label_SqlType.Size = new System.Drawing.Size(99, 20);
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
            this.ComboBox_SqlType.Location = new System.Drawing.Point(134, 23);
            this.ComboBox_SqlType.Name = "ComboBox_SqlType";
            this.ComboBox_SqlType.Size = new System.Drawing.Size(247, 28);
            this.ComboBox_SqlType.TabIndex = 1;
            this.ComboBox_SqlType.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SqlType_SelectedIndexChanged);
            // 
            // ConnectForm
            // 
            this.AcceptButton = this.Button_Connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(422, 220);
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
            this.Icon = Properties.Resources.Logo;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
    }
}