using ProyectoEmpleados;
using System;
using System.Windows.Forms;

namespace SistemaManejoEmpleados
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // INICIAR EL FORMULARIO PRINCIPAL REAL
            Application.Run(new FrmMain());
        }
    }
}
