using System;
using System.Windows.Forms;

namespace SistemaManejoEmpleados
{
    public partial class FrmEditarDepartamento : Form
    {
        // Propiedades para recibir y devolver la información
        public string DepartamentoID { get; set; }
        public string DepartamentoNombre { get; set; }

        // Saber si se guardaron los cambios
        public bool Guardado { get; private set; } = false;

        public FrmEditarDepartamento(string id, string nombre)
        {
            InitializeComponent();

            // Guardar los valores recibidos
            DepartamentoID = id;
            DepartamentoNombre = nombre;

            // Mostrarlos en la interfaz
            txtID.Text = id;
            txtNombre.Text = nombre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe escribir un nombre para el departamento.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar cambios
            DepartamentoNombre = txtNombre.Text.Trim();
            Guardado = true;

            MessageBox.Show("Departamento actualizado correctamente.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Guardado = false;
            this.Close();
        }

        // Eventos vacíos (NECESARIOS por el Designer)
        private void lblID_Click(object sender, EventArgs e) { }
        private void txtNombre_TextChanged(object sender, EventArgs e) { }
        private void txtID_TextChanged(object sender, EventArgs e) { }
        private void lblTitulo_Click(object sender, EventArgs e) { }
        private void lblNombre_Click(object sender, EventArgs e) { }
    }
}