using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.ModelsClasses
{
    static class User
    {
        private static string _usuario= "";

        public static string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private static string _empleado = "";

        public static string Empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }
    }
}
