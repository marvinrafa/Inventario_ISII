using DataModels;
using Inventario.ModelsClasses;
using Inventario.Reportes;
using LinqToDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Inventario
{
    public partial class FormEmpleados : Form
    {
        string id, nombre, rol;
        int telefono;
        bool modificando;
        TextboxEvent textboxEvent = new TextboxEvent();

        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtID.Text = "";
            txtTelefono.Text = "";
            txtNombre.Text = "";
            txtRol.Text = "";
            txtBusqueda.Text = "";
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
        private void cargarTabla()
        {
            try
            {
                using (var db = new InventarioDB())
                {
                    var q =
                        from c in db.Empleados
                        select new
                        {
                            c.Id,
                            c.Nombre,
                            c.Rol,
                            c.Telefono,
                        };
                    dtgEmpleados.DataSource = q.ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e);
            }
        }
        private void SaveOrModify(bool modify, string id, string nombre, string rol, int telefono)
        {
            if (nombre != "" && id != "" && rol != "" && telefono.ToString() != "")
            {
                if (modify)
                {
                    try
                    {
                        using (var db = new InventarioDB())
                        {
                            db.Empleados
                              .Where(p => p.Id == id)
                              .Set(p => p.Nombre, nombre)
                              .Set(p => p.Rol, rol)
                              .Set(p => p.Telefono, telefono)
                              .Update();
                        }
                        MessageBox.Show("Empleado modificado exitosamente");
                        ocultarElementos();
                        txtID.Enabled = true;
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
                            db.Insert(new Empleado
                            {
                                Id = id,
                                Nombre = nombre,
                                Rol = rol,
                                Telefono = telefono
                            }); ;
                        }
                        MessageBox.Show("Empleado Guardado");
                        ocultarElementos();
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
        private void delete(string id)
        {
            if (MessageBox.Show("¿Desea eliminar el Empleado?, Recuerde no podrá si tiene ususario activo", "Confirme eliminación",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    using (var db = new InventarioDB())
                    {
                        db.Empleados
                          .Where(p => p.Id == id)
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
        public List<Empleado> BuscarEmpleado(string searchFor)
        {
            using (var db = new InventarioDB())
            {
                var emps = from p in db.Empleados
                           select p;
                if (searchFor != null)
                {
                    emps = from p in emps
                           where p.Nombre.Contains(searchFor)
                           select p;
                }
                return emps.ToList();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            grpDatos.Enabled = true;
            modificando = false;
            btnGuardar.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            grpDatos.Enabled = true;
            modificando= true;
            btnGuardar.Visible = true;
            txtID.Enabled = false;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            delete(lblseleccionado.Text);
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

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxEvent.textAndNumbersKeyPress(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxEvent.textAndNumbersKeyPress(e);
        }

        private void txtRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxEvent.textAndNumbersKeyPress(e);
        }


        private void dtgEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                DataGridViewRow dgv = dtgEmpleados.Rows[e.RowIndex];
                lblseleccionado.Text = dgv.Cells[0].Value.ToString();
                txtID.Text = dgv.Cells[0].Value.ToString();
                txtNombre.Text = dgv.Cells[1].Value.ToString();
                txtTelefono.Text = dgv.Cells[3].Value.ToString();
                txtRol.Text = dgv.Cells[2].Value.ToString();
            }
        }

        private void dtgEmpleados_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 1; i < dtgEmpleados.ColumnCount; i++)
            {
                if (i >= 4)
                {
                    dtgEmpleados.Columns.RemoveAt(i);
                }
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxEvent.numberKeyPress(e);
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            dtgEmpleados.DataSource = BuscarEmpleado(txtBusqueda.Text);

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ReporteMateriales rep = new ReporteMateriales();
            rep.imprimir(dtgEmpleados);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            id = txtID.Text;
            nombre = txtNombre.Text;
            rol = txtRol.Text;
            telefono = int.Parse(txtTelefono.Text);
            SaveOrModify(modificando, id, nombre, rol, telefono);
        }


    }
}
