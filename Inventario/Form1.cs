using DataModels;
using Inventario.ModelsClasses;
using Inventario.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comprobarInventario();
        }

        private void comprobarInventario()
        {
            using (var db = new InventarioDB())
            {
                var q =
                    from c in db.Materiales
                    where c.Stock <= 5
                    select new
                    {
                        c.Stock,
                    };
                if (q.ToList().Count >= 1)
                {
                    MessageBox.Show("Favor, revise stock, quedan pocas unidades de ciertos materiales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            
            }

            
        }
        private void inventarioDisponibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMateriales frm = new formMateriales
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes frm = new FormClientes()
            {
                MdiParent = this
            };

            frm.Show();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarios frm = new FormUsuarios()
            {
                MdiParent = this
            };

            frm.Show();

        }

        private void cambiarImpresorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarImpresor frm = new CambiarImpresor()
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void historialDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpleados frm = new FormEmpleados()
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVender frm = new FormVender()
            {
                MdiParent = this
            };

            frm.Show();
        }

    
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta a punto de hacer un respaldo de la informacion. Desea continuar?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    Backup backup = new Backup();
                    backup.Respaldo();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hacer la siguiente operacion solo si esta seguro y el archivo de respaldo se encuentra en la ruta C:\\backupInventario.sql", "Advertencia",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    Backup backup = new Backup();
                backup.Restore();
                 }
                catch (Exception ex)
                 {
                MessageBox.Show(ex.ToString());
                    }
             }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            this.Close();
             
        }

        private void cambiarContrasenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarContrasena frm = new CambiarContrasena()
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "Ayuda", "index.html");
            Process.Start(filePath);
        }
    }
}
