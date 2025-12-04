using System;
using System.Windows.Forms;

namespace SistemaManejoEmpleados
{
    public partial class FrmAgregarCargo : Form
    {
        // Propiedad para devolver el cargo creado
        public string NombreCargo { get; private set; }

        public FrmAgregarCargo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe ingresar un nombre para el cargo.", 
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guarda el valor en la propiedad
            NombreCargo = nombre;

            MessageBox.Show("Cargo agregado correctamente.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // No requerido, pero existe el evento en tu Designer
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            // Evento vacío, no afecta diseño
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            // Evento vacío, no afecta diseño
        }
    }
}