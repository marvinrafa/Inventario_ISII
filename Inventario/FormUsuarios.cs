using DataModels;
using Inventario.ModelsClasses;
using LinqToDB;
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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text != "" && txtPassword.Text != "" && txtEmpleado.Text != "")
                {
                    if(txtPassword.Text.Length < 8)
                    {
                        MessageBox.Show("Contrasena debil, minimo 8 caracteres");
                    }
                    else
                    {
                        Crypto crypto = new Crypto();
                        String password = crypto.Encrypt(txtPassword.Text);
                        using (var db = new InventarioDB())
                        {
                            db.Insert(new Usuario
                            {
                                UsuarioColumn = txtUsuario.Text,
                                Contrasena = password,
                                IdEmpleado = txtEmpleado.Text,
                                Tipo = cmbTipo.SelectedIndex
                            });
                        }
                        MessageBox.Show("Usuario Guardado");
                        limpiar();
                    }
                
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
            catch (Exception fex)
            {
                MessageBox.Show("Datos incorrectos: " + fex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar()
        {
            txtPassword.Clear();
            txtEmpleado.Clear();
            txtUsuario.Clear();
        }
    }
}
