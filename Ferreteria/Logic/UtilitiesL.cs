using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class UtilitiesL
    {
        /* Validates the entry of only letters */
        public void SoloLetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar)) // Allows to erase
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar)) // Allows to add white spaces
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer parámetro: " + ex.StackTrace);
            }
        }

        /* Validates the entry of only numbers */
        public void SoloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar)) // Allows to erase
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar)) // Allows to add white spaces
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer parámetro: " + ex.StackTrace);
            }
        }
    }
}
