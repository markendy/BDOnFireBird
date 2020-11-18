using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public static class WinHelp
    {
        public static void ShowMessage(string message)
        {
            MessageBox.Show(message, "Уведомление");
        }
    }
}
