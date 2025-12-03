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

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleadosList frm = new FrmEmpleadosList();
            frm.ShowDialog();
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            FrmDepartamentosList frm = new FrmDepartamentosList();
            frm.ShowDialog();
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            FrmCargosList frm = new FrmCargosList();
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCargos_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDepartamentos_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEmpleados_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}