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
            this.process_bar = new System.Windows.Forms.ProgressBar();
            this.label_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // process_bar
            // 
            this.process_bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.process_bar.Location = new System.Drawing.Point(12, 12);
            this.process_bar.MarqueeAnimationSpeed = 16;
            this.process_bar.Name = "process_bar";
            this.process_bar.Size = new System.Drawing.Size(355, 23);
            this.process_bar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.process_bar.TabIndex = 0;
            // 
            // label_text
            // 
            this.label_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_text.Location = new System.Drawing.Point(0, 0);
            this.label_text.Name = "label_text";
            this.label_text.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.label_text.Size = new System.Drawing.Size(379, 109);
            this.label_text.TabIndex = 1;
            this.label_text.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // WaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(379, 109);
            this.ControlBox = false;
            this.Controls.Add(this.process_bar);
            this.Controls.Add(this.label_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WaitForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "正在生成...";
            this.Load += new System.EventHandler(this.WaitForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar process_bar;
        private System.Windows.Forms.Label label_text;
    }
}