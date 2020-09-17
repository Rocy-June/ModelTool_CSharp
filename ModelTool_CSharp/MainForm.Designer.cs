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
            this.TableCheckList = new System.Windows.Forms.CheckedListBox();
            this.GeneratedText = new System.Windows.Forms.TextBox();
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TableCheckList
            // 
            this.TableCheckList.Dock = System.Windows.Forms.DockStyle.Left;
            this.TableCheckList.FormattingEnabled = true;
            this.TableCheckList.Location = new System.Drawing.Point(0, 0);
            this.TableCheckList.Name = "TableCheckList";
            this.TableCheckList.Size = new System.Drawing.Size(235, 571);
            this.TableCheckList.TabIndex = 0;
            // 
            // GeneratedText
            // 
            this.GeneratedText.Dock = System.Windows.Forms.DockStyle.Left;
            this.GeneratedText.Location = new System.Drawing.Point(235, 0);
            this.GeneratedText.Multiline = true;
            this.GeneratedText.Name = "GeneratedText";
            this.GeneratedText.Size = new System.Drawing.Size(267, 571);
            this.GeneratedText.TabIndex = 1;
            // 
            // SettingPanel
            // 
            this.SettingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingPanel.Location = new System.Drawing.Point(502, 0);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.Size = new System.Drawing.Size(401, 571);
            this.SettingPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 571);
            this.Controls.Add(this.SettingPanel);
            this.Controls.Add(this.GeneratedText);
            this.Controls.Add(this.TableCheckList);
            this.Name = "MainForm";
            this.Text = "实体类生成工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox TableCheckList;
        private System.Windows.Forms.Panel SettingPanel;
        private System.Windows.Forms.TextBox GeneratedText;
    }
}

