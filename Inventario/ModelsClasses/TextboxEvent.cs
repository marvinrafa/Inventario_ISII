using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario.ModelsClasses
{
    class TextboxEvent
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar)) { e.Handled = false;  }
            else if(char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }

        public void numberKeyPress(KeyPressEventArgs e)
        {
            //Permite ingresar digitos
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            //No permite ingresar letras
            else if (char.IsLetter(e.KeyChar)) { e.Handled = true; }
           //Permite usar el backspace
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }

        }

        public void decimalKeyPress(KeyPressEventArgs e, TextBox textBox)
        {
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //Verifica si ya hay un punto decimal
            else if ((e.KeyChar == '.') && (!textBox.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        public void textAndNumbersKeyPress(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
    }
}
