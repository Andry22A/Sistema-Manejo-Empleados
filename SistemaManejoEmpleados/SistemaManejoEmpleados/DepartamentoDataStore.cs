using System.Collections.Generic;
using System.Linq;

namespace SistemaManejoEmpleados
{
    internal static class DepartamentoDataStore
    {
        public static List<Departamento> Departamentos = new List<Departamento>();

        public static void Agregar(Departamento d)
        {
            Departamentos.Add(d);
        }

        public static void Eliminar(int id)
        {
            Departamentos.RemoveAll(x => x.DepartamentoID == id);
        }
    }
}