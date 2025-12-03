using System.Collections.Generic;
using System.Linq;

namespace SistemaManejoEmpleados
{
    internal static class CargoDataStore
    {
        public static List<Cargo> Cargos = new List<Cargo>();

        public static void Agregar(Cargo c)
        {
            Cargos.Add(c);
        }

        public static void Eliminar(int id)
        {
            Cargos.RemoveAll(x => x.CargoID == id);
        }
    }
}