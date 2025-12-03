using System;

namespace SistemaManejoEmpleados
{
    public class Empleado
    {
        public int EmpleadoID { get; set; }
        public string Nombre { get; set; }
        public int DepartamentoID { get; set; }
        public int CargoID { get; set; }
        public DateTime FechaInicio { get; set; }
        public decimal Salario { get; set; }
        public string Estado { get; set; }

        // Calculados
        public string TiempoEnEmpresa { get; set; }
        public decimal AFP { get; set; }
        public decimal ARS { get; set; }
        public decimal ISR { get; set; }
    }
}