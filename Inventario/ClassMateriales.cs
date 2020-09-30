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
        private double precio_unitario;
        private int existencias;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio_Unitario { get => precio_unitario; set => precio_unitario = value; }
        public int Existencias { get => existencias; set => existencias = value; }
   
    }
}
