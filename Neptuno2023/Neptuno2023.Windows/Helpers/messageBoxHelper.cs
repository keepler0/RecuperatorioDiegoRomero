using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neptuno2023.Windows.Helpers
{
    public static class messageBoxHelper
    {
        public static DialogResult Question(string mensaje,string mensaje2)
        {
            DialogResult dr = MessageBox.Show(mensaje, mensaje2, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            return dr;
        }
        public static void Error(string mensaje)
        {
            MessageBox.Show(mensaje, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public static void Information(string mensaje, string mensaje2)
        {
            MessageBox.Show(mensaje, mensaje2, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
