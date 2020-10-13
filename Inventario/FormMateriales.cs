using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModels;
using Inventario.ModelsClasses;
using LinqToDB;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;
using Inventario.Reportes;

namespace Inventario
{
    public partial class formMateriales : Form
    {
        public bool modificandoMaterial = false;
        public bool modificandoProducto = false;
        public string descripcion = "",descripcionProducto;
        public double precioProducto;
        public int existencias, idMaterial, idProducto;
        public bool auto;
        TextboxEvent textboxEvent = new TextboxEvent();

        public formMateriales()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //---------------
        //METODOS DE MATERIALES 
        //.--------------

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modificandoMaterial == true)
            {
                try
                {
                    if (txtDescripcion.Text != "" && txtCantidad.Text != "")
                    {
                        descripcion = txtDescripcion.Text;
                        existencias = int.Parse(txtCantidad.Text);
                        auto = ObtenerBool(cmbAuto.SelectedIndex);
                        idMaterial = int.Parse(lblseleccionado.Text);

                        using (var db = new InventarioDB())
                        {
                            db.Materiales
                              .Where(p => p.Id == idMaterial)
                              .Set(p => p.Material, descripcion)
                              .Set(p => p.Stock, existencias)
                              .Set(p => p.Auto, auto)
                              .Update();
                        }
                        MessageBox.Show("Registro modificado");
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
                    if (txtDescripcion.Text != "" && txtCantidad.Text != "")
                    {
                        using (var db = new InventarioDB())
                        {
                            db.Insert(new Materiale
                            {
                                Material = txtDescripcion.Text,
                                Auto = ObtenerBool(cmbAuto.SelectedIndex),
                                Stock = int.Parse(txtCantidad.Text)
                            });
                        }   
                        MessageBox.Show("Material Guardado");
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

        private void limpiar()
        {
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtMaterialProducto.Text = "";
            tstPrecioProducto.Text = "";
            txtDescripcionProducto.Text = "";
        }

        //Método final al hacer consulta para volver a estado original
        private void ocultarElementos()
        {
            modificandoMaterial = false;
            cargarTabla();
            limpiar();
            grpDatos.Enabled = false;
            btnGuardar.Visible = false;
            txtBusquedaMaterial.Visible = false;
            lblBusquedaMaterial.Visible = false;
            lblseleccionado.Text = "Ninguno";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            grpDatos.Enabled = true;
            modificandoMaterial = false;
            btnGuardar.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            grpDatos.Enabled = true;
            modificandoMaterial = true;
            btnGuardar.Visible = true;
        }

        private void dtgMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
           
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                DataGridViewRow dgv = dtgMateriales.Rows[e.RowIndex];
                lblseleccionado.Text = dgv.Cells[0].Value.ToString();
                txtDescripcion.Text = dgv.Cells[1].Value.ToString();
                txtCantidad.Text = dgv.Cells[3].Value.ToString();
                if (bool.Parse(dgv.Cells[2].Value.ToString()) == true)
                {
                    cmbAuto.SelectedIndex = 1;
                }
                else
                {
                    cmbAuto.SelectedIndex = 0;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            idMaterial = int.Parse(lblseleccionado.Text);
            if (MessageBox.Show("¿Desea eliminar el Material?", "Confirme eliminación",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    using (var db = new InventarioDB())
                    {
                        db.Materiales
                          .Where(p => p.Id == idMaterial)
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

        private bool ObtenerBool(int indice)
        {
            if (indice == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void cargarTabla()
        {
            try
            {
                using (var db = new InventarioDB())
                {
                    var q =
                        from c in db.Materiales
                        select new
                        {
                            c.Id,
                            c.Material,
                            c.Auto,
                            c.Stock,
                        };
                    dtgMateriales.DataSource = q.ToList();
                }

                using (var db = new InventarioDB())
                {
                    var q =
                        from c in db.Productos
                        select new
                        {
                            ID_producto = c.Id,
                            c.Descripcion,
                            c.PrecioUnitario,
                            Material_Usado = c.Material,
                        };

                    dtgProductos.DataSource = q.ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e);
            }
        }

        private void MaterialesClass_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxEvent.textAndNumbersKeyPress(e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxEvent.numberKeyPress(e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtBusquedaMaterial.Visible == false)
            {
                txtBusquedaMaterial.Visible = true;
                lblBusquedaMaterial.Visible = true;
                txtBusquedaMaterial.Focus();
            }
            else
            {
                ocultarElementos();
            }
            
        }

        private void txtBusquedaMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            dtgMateriales.DataSource = BuscarMaterial(txtBusquedaMaterial.Text);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ReporteMateriales rep = new ReporteMateriales();
            rep.imprimir(dtgMateriales);
          

        }
        public List<Materiale> BuscarMaterial(string searchFor)
        {
            using (var db = new InventarioDB())
            {
                var mats = from p in db.Materiales
                               select p;
                if (searchFor != null)
                {
                    mats = from p in mats
                                where p.Material.Contains(searchFor)
                                select p;
                }
                return mats.ToList();
            }
        }

        //----------------------
        // MÉTODOS DE PRODUCTOS 
        //-----------------------
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            grpDatosProductos.Enabled = true;
            modificandoProducto = false;
            btnGuardarProducto.Visible = true;

        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (txtDescripcionProducto.Text != "" && txtMaterialProducto.Text != "" && tstPrecioProducto.Text != "")
            {
                if (modificandoProducto == true)
                {

                    try
                    {

                        descripcionProducto = txtDescripcionProducto.Text;
                        idMaterial = int.Parse(txtMaterialProducto.Text);
                        precioProducto = double.Parse(tstPrecioProducto.Text);
                        idProducto = int.Parse(lblProductoSeleccionado.Text);

                        using (var db = new InventarioDB())
                        {
                            db.Productos
                              .Where(p => p.Id == idProducto)
                              .Set(p => p.Descripcion, descripcionProducto)
                              .Set(p => p.Material, idMaterial)
                              .Set(p => p.PrecioUnitario, precioProducto)
                              .Update();
                        }
                        MessageBox.Show("Producto modificado exitosamente");
                        ocultaElementosProductos();
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
                        using (var db = new InventarioDB())
                        {
                            db.Insert(new Producto
                            {
                                Descripcion = txtDescripcionProducto.Text,
                                Material = int.Parse(txtMaterialProducto.Text),
                                PrecioUnitario = double.Parse(tstPrecioProducto.Text)
                            }); ;
                        }
                        MessageBox.Show("Producto Guardado");
                        ocultaElementosProductos();
                    }

                    catch (FormatException fex)
                    {
                        MessageBox.Show("Datos incorrectos: " + fex.Message);
                    }

                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            idProducto = int.Parse(lblProductoSeleccionado.Text);
            if (MessageBox.Show("¿Desea eliminar el Producto?", "Confirme eliminación",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    using (var db = new InventarioDB())
                    {
                        db.Productos
                          .Where(p => p.Id == idProducto)
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
                    ocultaElementosProductos();
                }
            }

        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            grpDatosProductos.Enabled = true;
            modificandoProducto = true;
            btnGuardarProducto.Visible = true;
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                btnModificarProducto.Enabled = true;
                btnEliminarProducto.Enabled = true;
                DataGridViewRow dgv = dtgProductos.Rows[e.RowIndex];
                if (e.RowIndex == -1)
                {
                    return;
                }
                lblProductoSeleccionado.Text = dgv.Cells[0].Value.ToString();
                txtDescripcionProducto.Text = dgv.Cells[1].Value.ToString();
                txtMaterialProducto.Text = dgv.Cells[3].Value.ToString();
                tstPrecioProducto.Text = dgv.Cells[2].Value.ToString();
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (txtBusquedaProducto.Visible == false)
            {
                txtBusquedaProducto.Visible = true;
                lblBusquedaProducto.Visible = true;
                txtBusquedaProducto.Focus();
            }
            else
            {
                ocultaElementosProductos();
            }

        }

        private void txtDescripcionProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxEvent.textAndNumbersKeyPress(e);
        }

        private void btnImprimirProductos_Click(object sender, EventArgs e)
        {
            ReporteProductos rep = new ReporteProductos();
            rep.imprimir(dtgProductos);
        }

        private void txtBusquedaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            dtgProductos.DataSource = BuscarProducto(txtBusquedaProducto.Text);

        }

        private void ocultaElementosProductos()
        {
            modificandoProducto= false;
            cargarTabla();
            limpiar();
            grpDatosProductos.Enabled = false;
            btnGuardarProducto.Visible = false;
            txtBusquedaProducto.Visible = false;
            lblBusquedaProducto.Visible = false;
            lblProductoSeleccionado.Text = "Ninguno";
        }

        private void dtgMateriales_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 1; i < dtgMateriales.ColumnCount; i++)
            {
                if (i >= 4)
                {
                    dtgMateriales.Columns.RemoveAt(i);
                }
            }
        }

        private void dtgProductos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 1; i < dtgProductos.ColumnCount; i++)
            {
                if (i >= 4)
                {
                    //Remover columnas que genera el ORM que no necesitamos
                    dtgProductos.Columns.RemoveAt(i);
                    dtgProductos.Columns.Remove("ibfk");
                }
            }
        }

        private void tstPrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxEvent.decimalKeyPress(e, tstPrecioProducto);
        }

        private void txtMaterialProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxEvent.numberKeyPress(e);
        }

        public List<Producto> BuscarProducto(string searchFor)
        {
            using (var db = new InventarioDB())
            {
                var prod = from p in db.Productos
                           select p;
                if (searchFor != null)
                {
                    prod = from p in prod
                           where p.Descripcion.Contains(searchFor)
                           select p;
                }
                return prod.ToList();
            }
        }

    }
}
