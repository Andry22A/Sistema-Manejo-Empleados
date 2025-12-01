using SistemaManejoEmpleados;
using System;
using System.Windows.Forms;

namespace ProyectoEmpleados
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Convierte este formulario en MDI
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        // -------------------------
        //  MENU: EMPLEADOS
        // -------------------------

        private void mostrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleadosList frm = new FrmEmpleadosList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleadoAgregar frm = new FrmEmpleadoAgregar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void actualizarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleadoActualizar frm = new FrmEmpleadoActualizar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eliminarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleadoEliminar frm = new FrmEmpleadoEliminar();
            frm.MdiParent = this;
            frm.Show();
        }

        // -------------------------
        //  MENU: DEPARTAMENTOS
        // -------------------------

        private void mostrarDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartamentosList frm = new FrmDepartamentosList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartamentoAgregar frm = new FrmDepartamentoAgregar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void actualizarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartamentoActualizar frm = new FrmDepartamentoActualizar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eliminarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartamentoEliminar frm = new FrmDepartamentoEliminar();
            frm.MdiParent = this;
            frm.Show();
        }

        // -------------------------
        //  MENU: CARGOS
        // -------------------------

        private void mostrarCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCargosList frm = new FrmCargosList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCargoAgregar frm = new FrmCargoAgregar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void actualizarCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCargoActualizar frm = new FrmCargoActualizar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eliminarCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCargoEliminar frm = new FrmCargoEliminar();
            frm.MdiParent = this;
            frm.Show();
        }

        // -------------------------
        //  MENU: EXPORTAR
        // -------------------------

        private void exportarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExportar frm = new FrmExportar();
            frm.MdiParent = this;
            frm.Show();
        }

        // -------------------------
        //  MENU: SALIR
        // -------------------------

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}