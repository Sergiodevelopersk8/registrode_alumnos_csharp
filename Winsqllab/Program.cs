using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winsqllab
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Principal inicio = new Principal();
            inicio.FormClosed += cerrarInicio;
            inicio.Show();
            Application.Run();
        }

        private static void cerrarInicio(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= cerrarInicio;

            if(Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += cerrarInicio;
            }
        }
    }
}
