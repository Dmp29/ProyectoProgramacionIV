using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ProyectoPrograIV
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login Login = new Login();
            Login.FormClosed += Login_Closed;
            Login.Show();
            Application.Run();

        }
        private static void Login_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= Login_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += Login_Closed;
            }
        }
    }
}
