using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            return;
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
    }
}
