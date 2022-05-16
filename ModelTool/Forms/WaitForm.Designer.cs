namespace ModelTool.Forms
{
    partial class WaitForm
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
            this.ProgressBar_Main = new System.Windows.Forms.ProgressBar();
            this.Label_Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProgressBar_Main
            // 
            this.ProgressBar_Main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar_Main.Location = new System.Drawing.Point(10, 10);
            this.ProgressBar_Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProgressBar_Main.MarqueeAnimationSpeed = 16;
            this.ProgressBar_Main.Name = "ProgressBar_Main";
            this.ProgressBar_Main.Size = new System.Drawing.Size(315, 18);
            this.ProgressBar_Main.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBar_Main.TabIndex = 1;
            // 
            // Label_Text
            // 
            this.Label_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Text.Location = new System.Drawing.Point(0, 0);
            this.Label_Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Text.Name = "Label_Text";
            this.Label_Text.Padding = new System.Windows.Forms.Padding(0, 0, 0, 24);
            this.Label_Text.Size = new System.Drawing.Size(334, 121);
            this.Label_Text.TabIndex = 0;
            this.Label_Text.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // WaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(334, 121);
            this.ControlBox = false;
            this.Controls.Add(this.ProgressBar_Main);
            this.Controls.Add(this.Label_Text);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = global::ModelTool.Properties.Resources.Logo;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WaitForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "正在生成...";
            this.Load += new System.EventHandler(this.WaitForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBar_Main;
        private System.Windows.Forms.Label Label_Text;
    }
}