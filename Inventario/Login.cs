using Inventario.ModelsClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario.Reportes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtContrasena.Clear();
            txtUsuario.Clear();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pass = txtContrasena.Text;
            Limpiar();
            if (pass != "" && user != "")
            {
                Sesion sesion = new Sesion();
                try
                {
                    
                    if (sesion.Entrar(user, pass)) {
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contrasena incorrectos");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            else
            {
                MessageBox.Show("Por Favor, ingrese los campos");
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string user = txtUsuario.Text;
                string pass = txtContrasena.Text;
                Limpiar();
                if (pass != "" && user != "")
                {
                    Sesion sesion = new Sesion();
                    try
                    {

                        if (sesion.Entrar(user, pass))
                        {
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contrasena incorrectos");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor, ingrese los campos");
                }
            }
        }
    }
}
