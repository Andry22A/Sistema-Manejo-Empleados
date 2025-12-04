using System;
using System.Windows.Forms;

namespace SistemaManejoEmpleados
{
    public partial class FrmEditarCargo : Form
    {
        // Propiedades para recibir y devolver los datos
        public string CargoID { get; set; }
        public string CargoNombre { get; set; }

        // Para saber si se guardó correctamente
        public bool Guardado { get; private set; } = false;

        public FrmEditarCargo(string id, string nombre)
        {
            InitializeComponent();

            // Guardamos los valores recibidos
            CargoID = id;
            CargoNombre = nombre;

            // Los colocamos en los TextBox
            txtID.Text = CargoID;
            txtNombre.Text = CargoNombre;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Guardado = false;
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación sencilla
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del cargo no puede estar vacío.");
                return;
            }

            // Guardamos los datos editados
            CargoNombre = txtNombre.Text.Trim();

            Guardado = true; // Sí se guardó correctamente
            this.Close();
        }

        // Eventos vacíos (NO BORRAR, EVITAN ERRORES)
        private void lblID_Click(object sender, EventArgs e) { }
        private void txtNombre_TextChanged(object sender, EventArgs e) { }
        private void txtID_TextChanged(object sender, EventArgs e) { }
        private void lblTitulo_Click(object sender, EventArgs e) { }
        private void lblNombre_Click(object sender, EventArgs e) { }
    }
}