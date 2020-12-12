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
    public partial class CambiarContrasena : Form
    {
        public CambiarContrasena()
        {

            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (verificarPassword(txtPasswordActual.Text))
            {
                if(txtPassword.Text == txtRepetir.Text && txtPassword.Text.Length > 7)
                {
                    Crypto crypto = new Crypto();
                    string password = crypto.Encrypt(txtPassword.Text);
                    using (var db = new InventarioDB())
                    {
                        db.Usuarios
                          .Where(p => p.UsuarioColumn == lblUsuario.Text)
                          .Set(p => p.Contrasena, password)
                          .Update();
                    }
                    MessageBox.Show("Su contrasena ha sido actualizada");

                }
                else
                {
                    MessageBox.Show("Su contrasena debe tener mas de 8 caracteres o no coincide");
                }
            }
            else
            {
                MessageBox.Show("La contrasena actual ingresada no es correcta");
            }
            limpiarCampos();

        }

        private void limpiarCampos()
        {
            txtPassword.Clear();
            txtPasswordActual.Clear();
            txtRepetir.Clear();
        }
        private bool verificarPassword(string password)
        {
            Crypto crypto = new Crypto();
            string contra = crypto.Encrypt(password);
            using (var db = new InventarioDB())
                {
                    var q =
                        from c in db.Usuarios
                        where c.UsuarioColumn == User.Usuario
                        select c.Contrasena;
                    if (q.ToList().Single().ToString() == contra)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
        
        }

        private void CambiarContrasena_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = User.Usuario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
