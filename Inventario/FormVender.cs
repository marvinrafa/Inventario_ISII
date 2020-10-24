using DataModels;
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
    public partial class FormVender : Form
    {
        public int _cliente=0,_producto,_articulo;
        public FormVender()
        {
            InitializeComponent();
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

        private void txtCliente_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            dtgCliente.DataSource = BuscarCliente(txtCliente.Text);

        }

        private void dtgCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            imgConfirmarCliente.Visible = true;
            DataGridViewRow dgv = dtgCliente.Rows[e.RowIndex];
            txtCliente.Text = dgv.Cells[0].Value.ToString();
            _cliente = int.Parse(dgv.Cells[0].Value.ToString());
        }

        private void cancelarVenta()
        {
            imgConfirmarCliente.Visible = false;
            txtCliente.Clear();
            dtgCliente.Columns.Clear();
            dtgProducto.Columns.Clear();
            dtgArticulos.Columns.Clear();
            _cliente = 0;
            btnEliminarArticulo.Enabled = false;
            btnAgregarArticulo.Enabled = false;
            btnGuardar.Enabled = false;
        }

  
        public List<Producto> BuscarProducto(string searchFor)
        {
            using (var db = new InventarioDB())
            {
                    var prod = from p in db.Productos
                           where p.Id == int.Parse(searchFor)
                           select p;
                
                return prod.ToList();
            }
        }

        private void FormVender_Load(object sender, EventArgs e)
        {

        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            if (dtgCliente.ColumnCount > 0)
            {
                imgConfirmarCliente.Visible = true;
                _cliente = int.Parse(dtgCliente.Rows[0].Cells[0].Value.ToString());
                txtCliente.Text = _cliente.ToString();
            }
            else
            {
                MessageBox.Show("Cliente no valido");
                cancelarVenta();
            }
        }
        private void agregarArticulo(int producto, int cantidad)
        {
            string descripcion="";
            double precio=0;
            using (var db = new InventarioDB())
            {
                var q =
                    from c in db.Productos where c.Id == producto
                    select new
                    {
                        ID_producto = c.Id,
                        c.Descripcion,
                        c.PrecioUnitario,
                        Material_Usado = c.Material,
                    };

               descripcion = q.ToList().Single().Descripcion;
               precio = double.Parse(q.ToList().Single().PrecioUnitario.ToString());
            }
            precio *= cantidad;
            if (dtgArticulos.Columns.Count <1)
            {
                dtgArticulos.Columns.Add("id_producto", "ID Producto");
                dtgArticulos.Columns.Add("id_producto", "ID Producto");
                dtgArticulos.Columns.Add("id_producto", "ID Producto");
                dtgArticulos.Columns.Add("id_producto", "ID Producto");
            }
            dtgArticulos.Rows.Add(producto, descripcion, cantidad,precio );
            dtgProducto.Columns.Clear();
            txtProducto.Clear();
            btnEliminarArticulo.Enabled = true;
            btnGuardar.Visible = true;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
                btnAgregarArticulo.Enabled = true;
                if (dtgProducto.ColumnCount > 0)
                {
                    _producto = int.Parse(dtgProducto.Rows[0].Cells[0].Value.ToString());
                    txtProducto.Text = _producto.ToString();
                     agregarArticulo(_producto, int.Parse(txtCantidad.Value.ToString()));

                  }
                else
                {
                    MessageBox.Show("Ingrese un producto valido");
                    txtProducto.Clear();
                    txtProducto.Focus();
                }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cancelarVenta();
        }

        private void dtgArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _articulo = dtgArticulos.Rows[e.RowIndex].Index;
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dtgArticulos.Rows.RemoveAt(_articulo);
        }

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            dtgProducto.DataSource = BuscarProducto(txtProducto.Text);
            btnAgregarArticulo.Enabled = true;
            dtgProducto.Columns.RemoveAt(4);

        }
    }
}
