﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventario
{
    public partial class Materiales : Form
    {
        public bool modificando = false;
        public string codigo = "";
        public string descripcion = "";
        public int existencias;
        public int auto;

        public Materiales()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modificando == true)
            {
              
                descripcion = txtDescripcion.Text;
                existencias = int.Parse(txtCantidad.Text);
                auto = cmbAuto.SelectedIndex;


                string sql = "UPDATE materiales SET material='" + descripcion + "', stock='" + existencias + "', auto='" + auto + "' WHERE id='" + lblseleccionado.Text + "'";

                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro modificado");
                    limpiar();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al modificar: " + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                    modificando = false;
                    cargarTabla("");
                    grpDatos.Enabled = false;
                    modificando = false;
                    btnGuardar.Visible = false;
                }
            }
            else
            {
                try
                {
                    descripcion = txtDescripcion.Text;
                    existencias = int.Parse(txtCantidad.Text);
                    auto = cmbAuto.SelectedIndex;

                    if (descripcion != "" && existencias > 0)
                    {

                        string sql = "INSERT INTO materiales (material, stock, auto) VALUES ('" + descripcion + "','" + existencias + "','" + auto + "')";

                        MySqlConnection conexionBD = Conexion.conexion();
                        conexionBD.Open();

                        try
                        {
                            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Registro guardado");
                            limpiar();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error al guardar: " + ex.Message);
                        }
                        finally
                        {
                            conexionBD.Close();
                            cargarTabla("");
                            grpDatos.Enabled = false;
                            modificando = false;
                            btnGuardar.Visible = false;
                        }
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
            modificando = false;
            btnGuardar.Visible = true;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            grpDatos.Enabled = true;
            modificando = true;
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
            String id = lblseleccionado.Text;

            string sql = "DELETE FROM materiales WHERE id='" + id + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado");
                limpiar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
                cargarTabla("");

            }
        }

        private void cargarTabla(string dato)
        {
            CtrlMateriales _ctrlMateriales = new CtrlMateriales();
            dtgMateriales.DataSource = _ctrlMateriales.consulta(dato);
        }

        private void MaterialesClass_Load(object sender, EventArgs e)
        {
            cargarTabla("");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
