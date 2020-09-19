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

namespace ModelTool_CSharp
{
    public partial class WaitForm : Form
    {
        private Thread workingThread;

        public WaitForm(int totalCount)
        {
            InitializeComponent();

            process_bar.Maximum = totalCount;
        }

        public void RefreshState(int nowCount, string showText)
        {
            Invoke(new Action(() =>
            {
                process_bar.Style = ProgressBarStyle.Blocks;
                process_bar.Value = nowCount;

                label_text.Text = showText;
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
