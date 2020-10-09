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
using LinqToDB;
using MySql.Data.MySqlClient;

namespace Inventario
{
    public partial class formMateriales : Form
    {
        public bool modificandoMaterial = false;
        public bool modificandoProducto = false;
        public string codigo = "";
        public string descripcion = "";
        public int existencias, idMaterial;
        public bool auto;
      

        public formMateriales()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


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
                        modificandoMaterial = false;
                        cargarTabla();
                        grpDatos.Enabled = false;
                        btnGuardar.Visible = false;
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
                        MessageBox.Show(cmbAuto.SelectedIndex.ToString());
                        using (var db = new InventarioDB())
                        {
                            db.Insert(new Materiale
                            {
                                Material = txtDescripcion.Text,
                                Auto = ObtenerBool(cmbAuto.SelectedIndex),
                                Stock = int.Parse(txtCantidad.Text)
                            });
                        }
                            cargarTabla();
                            MessageBox.Show("Material Guardado");
                        limpiar();
                            grpDatos.Enabled = false;
                            modificandoMaterial = false;
                            btnGuardar.Visible = false;   
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
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
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
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            DataGridViewRow dgv = dtgMateriales.Rows[e.RowIndex];
            lblseleccionado.Text = dgv.Cells[0].Value.ToString();
            txtDescripcion.Text = dgv.Cells[1].Value.ToString();
            txtCantidad.Text = dgv.Cells[3].Value.ToString();
            if (bool.Parse(dgv.Cells[2].Value.ToString()) == true )
            {
                cmbAuto.SelectedIndex = 1;

            }
            else
            {
                cmbAuto.SelectedIndex = 0;

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
                    limpiar();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
                finally
                {
                    cargarTabla();
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

        private void MaterialesClass_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
