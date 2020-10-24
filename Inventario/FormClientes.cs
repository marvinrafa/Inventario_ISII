using DataModels;
using Inventario.Reportes;
using LinqToDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
 using System.Linq;
using System.Windows.Forms;

namespace Inventario
{
    public partial class FormClientes : Form
    {
        bool modificando;
        int ID;
        string nombre, telefono;
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }
        private void ocultarElementos()
        {
            modificando = false;
            cargarTabla();
            limpiar();
            grpDatos.Enabled = false;
            btnGuardar.Visible = false;
            txtBusqueda.Visible = false;
            lblBusqueda.Visible = false;
            lblseleccionado.Text = "Ninguno";
        }
        private void limpiar()
        {
            txtNombre.Text = "";
            txtID.Text = "";
            txtTelefono.Text = "";
            txtBusqueda.Text = "";
        }

        private void cargarTabla()
        {
            try
            {
                using (var db = new InventarioDB())
                {
                    var q =
                        from c in db.Clientes
                        select new
                        {
                            c.Id,
                            c.ClienteColumn,
                            c.Telefono
                        };
                    dtgClientes.DataSource = q.ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e);
            }
        }

        public List<Cliente> BuscarCliente(string searchFor)
        {
            using (var db = new InventarioDB())
            {
                var clients = from p in db.Clientes
                              select p;
                if (searchFor != null)
                {
                    clients = from p in clients
                           where p.ClienteColumn.Contains(searchFor)
                           select p;
                }
                return clients.ToList();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            grpDatos.Enabled = true;
            modificando = false;
            btnGuardar.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ID = int.Parse(lblseleccionado.Text);
            if (MessageBox.Show("¿Desea eliminar el Material?", "Confirme eliminación",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    using (var db = new InventarioDB())
                    {
                        db.Clientes
                          .Where(p => p.Id == ID)
                          .Delete();
                    }
                    MessageBox.Show("Registro Eliminado");

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
                finally
                {
                    ocultarElementos();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            grpDatos.Enabled = true;
            modificando = true;
            btnGuardar.Visible = true;
            txtID.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Visible == false)
            {
                txtBusqueda.Visible = true;
                lblBusqueda.Visible = true;
                txtBusqueda.Focus();
            }
            else
            {
                ocultarElementos();
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            dtgClientes.DataSource = BuscarCliente(txtBusqueda.Text);

        }

        private void dtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                DataGridViewRow dgv = dtgClientes.Rows[e.RowIndex];
                lblseleccionado.Text = dgv.Cells[0].Value.ToString();
                txtID.Text = dgv.Cells[0].Value.ToString();
                txtNombre.Text = dgv.Cells[1].Value.ToString();
                txtTelefono.Text = dgv.Cells[2].Value.ToString();
            }
        }

        private void dtgClientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 1; i < dtgClientes.ColumnCount; i++)
            {
                if(i>= 3)
                {
                    dtgClientes.Columns.RemoveAt(i);
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ReporteClientes rep = new ReporteClientes();
            rep.imprimir(dtgClientes);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modificando == true)
            {
                try
                {
                    if (txtNombre.Text != "" && txtTelefono.Text != "")
                    {
                        nombre = txtNombre.Text;
                        telefono = txtTelefono.Text;
                        ID = int.Parse(lblseleccionado.Text);

                        using (var db = new InventarioDB())
                        {
                            db.Clientes
                              .Where(p => p.Id == ID)
                              .Set(p => p.ClienteColumn, nombre)
                              .Set(p => p.Telefono, telefono)
                              .Update();
                        }
                        MessageBox.Show("Cliente modificado");
                        txtID.Enabled = true;
                        ocultarElementos();
                    }
                    else
                    {
                        MessageBox.Show("Debe completar todos los campos");
                    }
                }
                catch (FormatException fex)
                {
                    MessageBox.Show("Datos incorrectos: " + fex.Message);
                }
            }
            else
            {
                try
                {
                    if (txtID.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "")
                    {
                        using (var db = new InventarioDB())
                        {
                            db.Insert(new Cliente
                            {
                                Id = int.Parse(txtID.Text),
                                ClienteColumn= txtNombre.Text,
                                Telefono = txtTelefono.Text
                            }) ; 
                        }
                        MessageBox.Show("Cliente Guardado");
                        ocultarElementos();
                    }
                    else
                    {
                        MessageBox.Show("Debe completar todos los campos");
                    }
                }
                catch (FormatException fex)
                {
                    MessageBox.Show("Datos incorrectos: " + fex.Message);
                }
            }
        }
    }
}
