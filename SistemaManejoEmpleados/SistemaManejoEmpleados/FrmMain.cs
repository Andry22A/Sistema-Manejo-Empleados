using System;
using System.Windows.Forms;

namespace SistemaManejoEmpleados
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // No tocar diseño
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleadosList frm = new FrmEmpleadosList();
            frm.ShowDialog();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            FrmAgregarEmpleado frm = new FrmAgregarEmpleado();
            frm.ShowDialog();
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            FrmCargosList frm = new FrmCargosList();
            frm.ShowDialog();
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            FrmDepartamentosList frm = new FrmDepartamentosList();
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            // Evento vacío para evitar error
        }
    }
}
