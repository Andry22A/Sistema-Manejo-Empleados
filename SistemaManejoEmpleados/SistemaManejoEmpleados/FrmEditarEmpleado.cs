using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaManejoEmpleados
{
    public partial class FrmEditarEmpleado : Form
    {
        // Variables públicas para regresar datos
        public bool Guardado { get; private set; } = false;

        public string EmpleadoID => txtID.Text;
        public string EmpleadoNombre => txtNombre.Text;
        public string EmpleadoApellido => txtApellido.Text;
        public string EmpleadoDepartamento => cmbDepartamento.SelectedItem?.ToString();
        public string EmpleadoCargo => cmbCargo.Text;
        public string EmpleadoSalario => txtSalario.Text;
        public DateTime EmpleadoFechaIngreso => dtpFechaIngreso.Value;

        // Datos recibidos del formulario principal
        private string _id;
        private string _nombre;
        private string _apellido;
        private string _departamento;
        private string _cargo;
        private string _salario;
        private DateTime _fechaIngreso;

        private List<string> _listaDepartamentos;
        private List<string> _listaCargos;

        // Constructor con datos (el que usarás desde FrmEmpleadosList)
        public FrmEditarEmpleado(
            string id,
            string nombre,
            string apellido,
            string departamento,
            string cargo,
            string salario,
            DateTime fechaIngreso,
            List<string> departamentos,
            List<string> cargos)
        {
            InitializeComponent();

            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _departamento = departamento;
            _cargo = cargo;
            _salario = salario;
            _fechaIngreso = fechaIngreso;

            _listaDepartamentos = departamentos;
            _listaCargos = cargos;
        }

        private void FrmEditarEmpleado_Load(object sender, EventArgs e)
        {
            // Cargar listas
            cmbDepartamento.Items.AddRange(_listaDepartamentos.ToArray());

            // Autocompletado del cargo (TextBox)
            var cargoAuto = new AutoCompleteStringCollection();
            cargoAuto.AddRange(_listaCargos.ToArray());
            cmbCargo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCargo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbCargo.AutoCompleteCustomSource = cargoAuto;

            // Cargar datos
            txtID.Text = _id;
            txtNombre.Text = _nombre;
            txtApellido.Text = _apellido;
            cmbDepartamento.SelectedItem = _departamento;
            cmbCargo.Text = _cargo;
            txtSalario.Text = _salario;
            dtpFechaIngreso.Value = _fechaIngreso;
        }

        // -----------------------
        // BOTÓN GUARDAR
        // -----------------------
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" ||
                txtApellido.Text.Trim() == "" ||
                cmbDepartamento.SelectedItem == null ||
                cmbCargo.Text.Trim() == "" ||
                txtSalario.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtSalario.Text, out _))
            {
                MessageBox.Show("El salario debe ser un número válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Guardado = true;
            this.Close();
        }

        // -----------------------
        // BOTÓN CANCELAR
        // -----------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Guardado = false;
            this.Close();
        }

        // -----------------------
        // EVENTOS VACÍOS (requeridos por Designer)
        // -----------------------
        private void txtSalario_TextChanged(object sender, EventArgs e) { }
        private void cmbCargo_TextChanged(object sender, EventArgs e) { }
        private void lblSalario_Click(object sender, EventArgs e) { }
        private void lblFechaIngreso_Click(object sender, EventArgs e) { }
        private void lblCargo_Click(object sender, EventArgs e) { }
        private void lblDepartamento_Click(object sender, EventArgs e) { }
        private void lblApellido_Click(object sender, EventArgs e) { }
        private void lblNombre_Click(object sender, EventArgs e) { }
        private void lblID_Click(object sender, EventArgs e) { }
        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e) { }
        private void txtApellido_TextChanged(object sender, EventArgs e) { }
        private void txtNombre_TextChanged(object sender, EventArgs e) { }
        private void txtID_TextChanged(object sender, EventArgs e) { }
        private void lblTitulo_Click(object sender, EventArgs e) { }
    }
}