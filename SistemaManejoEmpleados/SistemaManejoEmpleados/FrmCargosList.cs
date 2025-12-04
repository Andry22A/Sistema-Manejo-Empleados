using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace SistemaManejoEmpleados
{
    public partial class FrmCargosList : Form
    {
        // Lista de cargos simulando una base de datos
        public static List<string> ListaCargos = new List<string>()
        {
            "Gerente",
            "Supervisor",
            "Contador",
            "Vendedor"
        };

        public FrmCargosList()
        {
            InitializeComponent();
        }

        private void FrmCargosList_Load(object sender, EventArgs e)
        {
            CargarCargos();
        }

        private void CargarCargos()
        {
            dgvCargos.DataSource = null;
            dgvCargos.DataSource = ListaCargos.Select(x => new { Cargo = x }).ToList();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {
            // Nada por ahora
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim().ToLower();
            var resultados = ListaCargos
                .Where(c => c.ToLower().Contains(filtro))
                .Select(c => new { Cargo = c })
                .ToList();

            dgvCargos.DataSource = null;
            dgvCargos.DataSource = resultados;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nuevoCargo = Prompt.ShowDialog("Introduce el nombre del cargo:", "Agregar Cargo", "");

            if (!string.IsNullOrWhiteSpace(nuevoCargo))
            {
                ListaCargos.Add(nuevoCargo.Trim());
                CargarCargos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCargos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cargo primero.");
                return;
            }

            string cargoActual = dgvCargos.CurrentRow.Cells[0].Value.ToString();
            string nuevoNombre = Prompt.ShowDialog("Editar cargo:", "Editar", cargoActual);

            if (!string.IsNullOrWhiteSpace(nuevoNombre))
            {
                int index = ListaCargos.IndexOf(cargoActual);
                if (index >= 0)
                {
                    ListaCargos[index] = nuevoNombre.Trim();
                    CargarCargos();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCargos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cargo primero.");
                return;
            }

            string cargo = dgvCargos.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("¿Seguro que desea eliminar este cargo?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ListaCargos.Remove(cargo);
                CargarCargos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarCargos();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivo CSV|*.csv";
            save.FileName = "Cargos.csv";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(save.FileName))
                {
                    sw.WriteLine("Cargo");
                    foreach (var c in ListaCargos)
                    {
                        sw.WriteLine(c);
                    }
                }

                MessageBox.Show("Archivo CSV exportado correctamente.");
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e) { }
        private void dgvCargos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }

    // Clase Prompt para pedir texto al usuario sin usar Microsoft.VisualBasic
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption, string defaultValue = "")
        {
            Form prompt = new Form()
            {
                Width = 520,
                Height = 170,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                MaximizeBox = false
            };

            Label textLabel = new Label() { Left = 12, Top = 12, AutoSize = true, Text = text };
            TextBox textBox = new TextBox() { Left = 12, Top = 40, Width = 480, Text = defaultValue ?? "" };

            Button ok = new Button() { Text = "OK", Left = 320, Width = 80, Top = 76, DialogResult = DialogResult.OK };
            Button cancel = new Button() { Text = "Cancelar", Left = 412, Width = 80, Top = 76, DialogResult = DialogResult.Cancel };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(ok);
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = ok;
            prompt.CancelButton = cancel;

            var result = prompt.ShowDialog();
            return result == DialogResult.OK ? textBox.Text : null;
        }
    }
}