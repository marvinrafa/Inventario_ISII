using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class ClassMateriales
    {
 
        private string codigo;

        private string descripcion;
        private bool auto;
        private int existencias;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Stock_Automatico { get => auto; set => auto = value; }
        public int Existencias { get => existencias; set => existencias = value; }
   
    }
}
