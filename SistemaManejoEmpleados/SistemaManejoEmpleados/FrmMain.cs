using System;
using System.Windows.Forms;

namespace ProyectoEmpleados
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        // -----------------------
        // EMPLEADOS
        // -----------------------

        private void mostrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá Mostrar Empleados.");
        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá Agregar Empleado.");
        }

        private void actualizarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá Actualizar Empleado.");
        }

        private void eliminarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá Eliminar Empleado.");
        }

        // -----------------------
        // DEPARTAMENTOS
        // -----------------------

        private void mostrarDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá Mostrar Departamentos.");
        }

        private void agregarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá Agregar Departamento.");
        }

        private void actualizarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá Actualizar Departamento.");
        }

        private void eliminarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá Eliminar Departamento.");
        }

        // -----------------------
        // CARGOS
        // -----------------------

        private void mostrarCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá Mostrar Cargos.");
        }

        private void agregarCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá Agregar Cargo.");
        }

        private void actualizarCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá Actualizar Cargo.");
        }

        private void eliminarCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá Eliminar Cargo.");
        }

        // -----------------------
        // EXPORTAR
        // -----------------------

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá la exportación.");
        }

        // -----------------------
        // SALIR
        // -----------------------

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exportarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}