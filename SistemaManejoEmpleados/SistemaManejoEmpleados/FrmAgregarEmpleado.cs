using System;
using System.Windows.Forms;

namespace SistemaManejoEmpleados
{
    public partial class FrmAgregarEmpleado : Form
    {
        public FrmAgregarEmpleado()
        {
            InitializeComponent();

            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");

            cmbDepartamento.Items.AddRange(new string[]
            {
                "Administración", "Ventas", "Recursos Humanos", "Finanzas", "IT", "Compras"
            });

            cmbCargo.Items.AddRange(new string[]
            {
                "Gerente", "Asistente", "Cajero", "Supervisor", "Analista"
            });
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Empleado guardado correctamente.");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}