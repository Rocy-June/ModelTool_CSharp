using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelTool_CSharp
{
    public partial class GeneratingForm : Form
    {
        public GeneratingForm(int totalCount)
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
    }
}
