using System.Collections.Generic;

namespace SistemaManejoEmpleados
{
    public static class EmpleadoDataStore
    {
        public static List<Empleado> Empleados = new List<Empleado>();

        public static void Agregar(Empleado e)
        {
            Empleados.Add(e);
        }

        public static void Eliminar(int id)
        {
            Empleados.RemoveAll(x => x.EmpleadoID == id);
        }
    }
}