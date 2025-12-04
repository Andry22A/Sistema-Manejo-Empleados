using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SistemaManejoEmpleados
{
    public partial class FrmDepartamentosList : Form
    {
        // Lista que funcionará como "base de datos"
        private List<string> listaDepartamentos = new List<string>()
        {
            "Recursos Humanos",
            "Contabilidad",
            "Ventas",
            "Sistemas"
        };

        public FrmDepartamentosList()
        {
            InitializeComponent();
        }

        private void FrmDepartamentosList_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvDepartamentos.DataSource = null;
            dgvDepartamentos.DataSource = listaDepartamentos
                .Select(d => new { Departamento = d })
                .ToList();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim().ToLower();

            var filtrado = listaDepartamentos
                .Where(x => x.ToLower().Contains(texto))
                .Select(x => new { Departamento = x })
                .ToList();

            dgvDepartamentos.DataSource = null;
            dgvDepartamentos.DataSource = filtrado;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nuevo = Prompt("Ingrese el nombre del departamento:");

            if (!string.IsNullOrWhiteSpace(nuevo))
            {
                listaDepartamentos.Add(nuevo.Trim());
                CargarDatos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDepartamentos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un departamento.");
                return;
            }

            string actual = dgvDepartamentos.CurrentRow.Cells[0].Value.ToString();
            string nuevo = Prompt("Editar departamento:", actual);

            if (!string.IsNullOrWhiteSpace(nuevo))
            {
                int index = listaDepartamentos.IndexOf(actual);
                listaDepartamentos[index] = nuevo.Trim();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDepartamentos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un departamento.");
                return;
            }

            string dep = dgvDepartamentos.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("¿Desea eliminar este departamento?",
                                "Confirmar",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listaDepartamentos.Remove(dep);
                CargarDatos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivo CSV (*.csv)|*.csv";
            save.FileName = "Departamentos.csv";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(save.FileName))
                {
                    sw.WriteLine("Departamento");
                    foreach (var dep in listaDepartamentos)
                        sw.WriteLine(dep);
                }

                MessageBox.Show("Exportado correctamente.");
            }
        }

        // ---------------------------
        // VENTANA PEQUEÑA PARA ESCRIBIR TEXTO
        // ---------------------------
        private string Prompt(string mensaje, string valorPorDefecto = "")
        {
            Form prompt = new Form()
            {
                Width = 420,
                Height = 160,
                Text = "Ingresar dato",
                StartPosition = FormStartPosition.CenterScreen
            };

            Label lbl = new Label() { Left = 20, Top = 20, Text = mensaje, AutoSize = true };
            TextBox txt = new TextBox() { Left = 20, Top = 50, Width = 360, Text = valorPorDefecto };

            Button ok = new Button() { Text = "Aceptar", Left = 220, Width = 75, Top = 80 };
            Button cancel = new Button() { Text = "Cancelar", Left = 305, Width = 75, Top = 80 };

            ok.DialogResult = DialogResult.OK;
            cancel.DialogResult = DialogResult.Cancel;

            prompt.Controls.Add(lbl);
            prompt.Controls.Add(txt);
            prompt.Controls.Add(ok);
            prompt.Controls.Add(cancel);

            var result = prompt.ShowDialog();

            return result == DialogResult.OK ? txt.Text : null;
        }

        private void lblBuscar_Click(object sender, EventArgs e) { }
        private void lblTitulo_Click(object sender, EventArgs e) { }
        private void dgvDepartamentos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
