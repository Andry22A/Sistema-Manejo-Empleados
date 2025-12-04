using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace SistemaManejoEmpleados
{
    public partial class FrmEmpleadosList : Form
    {
        private List<Empleado> empleados = new List<Empleado>();

        public FrmEmpleadosList()
        {
            InitializeComponent();
        }

        private void FrmEmpleadosList_Load(object sender, EventArgs e)
        {
            CargarDatos();
            ActualizarTabla();
        }

        private void CargarDatos()
        {
            empleados.Add(new Empleado
            {
                EmpleadoID = 1,
                Nombre = "Juan Pérez",
                DepartamentoID = 2,
                CargoID = 1,
                FechaInicio = new DateTime(2020, 1, 15),
                Salario = 30000,
                Estado = "Activo",
                TiempoEnEmpresa = CalcularTiempo(new DateTime(2020, 1, 15)),
                AFP = CalcularAFP(30000),
                ARS = CalcularARS(30000),
                ISR = CalcularISR(30000)
            });

            empleados.Add(new Empleado
            {
                EmpleadoID = 2,
                Nombre = "Ana López",
                DepartamentoID = 1,
                CargoID = 3,
                FechaInicio = new DateTime(2022, 5, 10),
                Salario = 25000,
                Estado = "Activo",
                TiempoEnEmpresa = CalcularTiempo(new DateTime(2022, 5, 10)),
                AFP = CalcularAFP(25000),
                ARS = CalcularARS(25000),
                ISR = CalcularISR(25000)
            });
        }

        private string CalcularTiempo(DateTime fecha)
        {
            TimeSpan ts = DateTime.Now - fecha;
            int años = (int)(ts.Days / 365);
            return $"{años} años";
        }

        private decimal CalcularAFP(decimal salario) => salario * 0.0287m;
        private decimal CalcularARS(decimal salario) => salario * 0.0304m;
        private decimal CalcularISR(decimal salario)
        {
            if (salario < 34685) return 0;
            if (salario < 52027) return salario * 0.15m;
            return salario * 0.20m;
        }

        private void ActualizarTabla()
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = empleados;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string b = txtBuscar.Text.ToLower();

            var resultado = empleados.Where(x =>
                x.Nombre.ToLower().Contains(b) ||
                x.Estado.ToLower().Contains(b) ||
                x.DepartamentoID.ToString().Contains(b) ||
                x.CargoID.ToString().Contains(b)
            ).ToList();

            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = resultado;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = empleados.Count > 0 ? empleados.Max(x => x.EmpleadoID) + 1 : 1;

            empleados.Add(new Empleado
            {
                EmpleadoID = id,
                Nombre = "Nuevo empleado",
                DepartamentoID = 0,
                CargoID = 0,
                FechaInicio = DateTime.Now,
                Salario = 0,
                Estado = "Activo",
                TiempoEnEmpresa = "0 años",
                AFP = 0,
                ARS = 0,
                ISR = 0
            });

            ActualizarTabla();
            MessageBox.Show("Empleado agregado.");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un empleado.");
                return;
            }

            int id = (int)dgvEmpleados.CurrentRow.Cells["EmpleadoID"].Value;
            var emp = empleados.First(x => x.EmpleadoID == id);

            emp.Nombre = "Empleado Editado";
            emp.Salario += 5000;
            emp.AFP = CalcularAFP(emp.Salario);
            emp.ARS = CalcularARS(emp.Salario);
            emp.ISR = CalcularISR(emp.Salario);

            ActualizarTabla();
            MessageBox.Show("Empleado editado.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un empleado.");
                return;
            }

            int id = (int)dgvEmpleados.CurrentRow.Cells["EmpleadoID"].Value;
            empleados.RemoveAll(x => x.EmpleadoID == id);

            ActualizarTabla();
            MessageBox.Show("Empleado eliminado.");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
            MessageBox.Show("Lista actualizada.");
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string ruta = "empleados.csv";

            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine("ID,Nombre,Departamento,Cargo,FechaInicio,Salario,Estado,Tiempo,AFP,ARS,ISR");

                foreach (var emp in empleados)
                {
                    sw.WriteLine($"{emp.EmpleadoID},{emp.Nombre},{emp.DepartamentoID},{emp.CargoID},{emp.FechaInicio},{emp.Salario},{emp.Estado},{emp.TiempoEnEmpresa},{emp.AFP},{emp.ARS},{emp.ISR}");
                }
            }

            MessageBox.Show("CSV exportado correctamente.");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Eventos vacíos del diseñador
        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblTitulo_Click(object sender, EventArgs e) { }
        private void lblBuscar_Click(object sender, EventArgs e) { }
    }
}