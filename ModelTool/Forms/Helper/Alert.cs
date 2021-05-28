using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelTool.Forms.Helper
{
    public static class Alert
    {
        public static void Info(
            string message,
            string caption = "提示",
            MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);
        }

        public static void Warning(
            string message,
            string caption = "警告",
            MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
        }

        public static void Error(
            string message,
            string caption = "错误",
            MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
        }
    }
}
