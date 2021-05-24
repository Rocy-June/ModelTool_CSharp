
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
            this.SuspendLayout();
            // 
            // Label_IP
            // 
            this.Label_IP.AutoSize = true;
            this.Label_IP.Location = new System.Drawing.Point(64, 38);
            this.Label_IP.Name = "Label_IP";
            this.Label_IP.Size = new System.Drawing.Size(38, 15);
            this.Label_IP.TabIndex = 0;
            this.Label_IP.Text = "IP：";
            // 
            // TextBox_IP
            // 
            this.TextBox_IP.Location = new System.Drawing.Point(108, 35);
            this.TextBox_IP.MaxLength = 15;
            this.TextBox_IP.Name = "TextBox_IP";
            this.TextBox_IP.Size = new System.Drawing.Size(247, 25);
            this.TextBox_IP.TabIndex = 1;
            this.TextBox_IP.TextChanged += new System.EventHandler(this.TextBox_IP_TextChanged);
            // 
            // TextBox_Account
            // 
            this.TextBox_Account.Location = new System.Drawing.Point(108, 66);
            this.TextBox_Account.Name = "TextBox_Account";
            this.TextBox_Account.Size = new System.Drawing.Size(247, 25);
            this.TextBox_Account.TabIndex = 3;
            this.TextBox_Account.TextChanged += new System.EventHandler(this.TextBox_Account_TextChanged);
            // 
            // Label_Account
            // 
            this.Label_Account.AutoSize = true;
            this.Label_Account.Location = new System.Drawing.Point(35, 69);
            this.Label_Account.Name = "Label_Account";
            this.Label_Account.Size = new System.Drawing.Size(67, 15);
            this.Label_Account.TabIndex = 2;
            this.Label_Account.Text = "用户名：";
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Location = new System.Drawing.Point(108, 97);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '*';
            this.TextBox_Password.Size = new System.Drawing.Size(247, 25);
            this.TextBox_Password.TabIndex = 5;
            this.TextBox_Password.TextChanged += new System.EventHandler(this.TextBox_Password_TextChanged);
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(50, 100);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(52, 15);
            this.Label_Password.TabIndex = 4;
            this.Label_Password.Text = "密码：";
            // 
            // Button_Connect
            // 
            this.Button_Connect.Location = new System.Drawing.Point(187, 140);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(85, 32);
            this.Button_Connect.TabIndex = 6;
            this.Button_Connect.Text = "建立连接";
            this.Button_Connect.UseVisualStyleBackColor = true;
            this.Button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(422, 209);
            this.Controls.Add(this.Button_Connect);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.TextBox_Account);
            this.Controls.Add(this.Label_Account);
            this.Controls.Add(this.TextBox_IP);
            this.Controls.Add(this.Label_IP);
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
    }
}