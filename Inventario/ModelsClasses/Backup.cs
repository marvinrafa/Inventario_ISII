using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Configuration;

namespace Inventario.ModelsClasses
{
    class Backup
    {
        public void Respaldo()
        {
            string constring = ConfigurationManager.ConnectionStrings["Inventario"].ConnectionString;

            string file = "C:/respaldos/backupInventario.sql";
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                    }
                }
            }
        }

        public void Restore()
        {
            string constring = ConfigurationManager.ConnectionStrings["Inventario"].ConnectionString;

            string file = "C:/respaldos/backupInventario.sql";
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(file);
                        conn.Close();
                    }
                }
            }
        }
    }
}
