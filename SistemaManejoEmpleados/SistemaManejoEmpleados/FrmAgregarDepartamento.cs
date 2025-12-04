using System;
using System.Windows.Forms;

namespace SistemaManejoEmpleados
{
    public partial class FrmAgregarDepartamento : Form
    {
        // Propiedad para devolver el nombre ingresado
        public string NombreDepartamento { get; private set; }

        public FrmAgregarDepartamento()
        {
            InitializeComponent(); // ← YA NO DA ERROR
        }

        private void FrmAgregarDepartamento_Load(object sender, EventArgs e)
        {
            // No necesitas poner nada aquí
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe ingresar un nombre para el departamento.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NombreDepartamento = nombre;

            MessageBox.Show("Departamento agregado correctamente.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            // Evento vacío para evitar errores
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // Evento vacío
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            // Evento vacío
        }

        private void lblTitulo_Click_1(object sender, EventArgs e)
        {

        }
    }
}