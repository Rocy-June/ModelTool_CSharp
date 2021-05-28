using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelTool.Forms
{
    public partial class WaitForm : Form
    {
        private Thread workingThread;

        public WaitForm(string title, int totalCount = 0)
        {
            InitializeComponent();

            Name = title;

            if (totalCount > 0)
            {
                ProgressBar_Main.Style = ProgressBarStyle.Continuous;
                ProgressBar_Main.Maximum = totalCount;
            }
            else 
            {
                ProgressBar_Main.Style = ProgressBarStyle.Marquee;
                Label_Text.Text = "请稍候...";
            }
        }

        public void RefreshState(int nowCount, string showText)
        {
            Invoke(new Action(() =>
            {
                ProgressBar_Main.Style = ProgressBarStyle.Continuous;
                ProgressBar_Main.Value = nowCount;

                Label_Text.Text = showText;
            }));
        }

        public new void Show()
        {
            ShowDialog();
        }

        public void StartWork(Thread waitThread)
        {
            workingThread = waitThread;
            ShowDialog();
        }

        public void WorkComplete()
        {
            Invoke(new Action(() =>
            {
                Close();
            }));
        }

        private void WaitForm_Load(object sender, EventArgs e)
        {
            if (workingThread == null)
            {
                throw new ArgumentNullException();
            }

            workingThread.Start();
        }
    }
}
