using System.Collections.Generic;
using System.Linq;

namespace SistemaManejoEmpleados
{
    public static class EmpleadoDataStore
    {
        public static List<Empleado> ListaEmpleados { get; private set; } = new List<Empleado>();

        public static void Agregar(Empleado empleado)
        {
            ListaEmpleados.Add(empleado);
        }

        public static int GenerarId()
        {
            if (ListaEmpleados.Count == 0)
                return 1;

            return ListaEmpleados.Max(e => e.Id) + 1;
        }
    }
}