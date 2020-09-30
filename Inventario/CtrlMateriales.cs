using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace Inventario
{
    class CtrlMateriales:Conexion
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT id, material, auto, stock FROM materiales";
            }
            else
            {
                sql = "SELECT id, material, auto, stock FROM materiales";
            }

            try
            {
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    ClassMateriales _materiales = new ClassMateriales();
                    _materiales.Codigo = reader[0].ToString();
                    _materiales.Descripcion = reader[1].ToString();
                    _materiales.Stock_Automatico = bool.Parse(reader[2].ToString());
                    _materiales.Existencias = int.Parse(reader[3].ToString());
                    lista.Add(_materiales);
                }
            }
            catch (MySqlException ex)
            {
                
            }
            return lista;
        }
    }
}
