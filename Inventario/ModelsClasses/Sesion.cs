using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels;
using LinqToDB;


namespace Inventario.ModelsClasses
{
    class Sesion
    {
        public bool Entrar(string username, string password)
        {
            Crypto crypto = new Crypto();
            string contra = crypto.Encrypt(password);
            bool usuarioVerificado = false;
            bool contraVerificada = false;

            using (var db = new InventarioDB())
            {
                var q =
                    from c in db.Usuarios
                    where c.UsuarioColumn == username
                    select c.UsuarioColumn;
                if (q.ToList().Count >= 1 ) {
                    usuarioVerificado = true;
                    User.Usuario = username;
                }
                else
                {
                    return false;
                }
            }
            if (usuarioVerificado)
            {
                using (var db = new InventarioDB())
                {
                    var q =
                        from c in db.Usuarios
                        where c.UsuarioColumn == username
                        select c.Contrasena;
                    if ( q.ToList().Single().ToString() == contra)
                    {
                        contraVerificada = true;
                    }
                    else
                    {
                        return false;

                    }
                }
            }
            if (contraVerificada)
            {
                using (var db = new InventarioDB())
                {
                    var q =
                        from c in db.Usuarios
                        where c.UsuarioColumn == username
                        select c.IdEmpleado;
                    if (q.ToList().Count >= 1)
                    {
                        User.Empleado = q.ToList().Single().ToString();
                    }
                }
            }
            if (contraVerificada)
            {
                using (var db = new InventarioDB())
                {
                    var q =
                        from c in db.Usuarios
                        where c.UsuarioColumn == username
                        select c.Tipo;
                    if (q.ToList().Single().ToString() == "1" )
                    {
                        Form1 frm = new Form1();
                        frm.menuStrip1.Items[3].Enabled = false;
                        frm.menuStrip1.Items[4].Enabled = false;
                        frm.usuarioStrip.Text = User.Usuario;
                        frm.Show();
                        return true;
                    }
                    else
                    {
                        Form1 frm = new Form1();
             
                        frm.usuarioStrip.Text = User.Usuario;
                        frm.Show();
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
