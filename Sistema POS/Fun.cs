using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_POS
{
    public static class Fun
    {
        public static bool CheckCommaInTextbox(KeyPressEventArgs e, TextBox textBox)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                if (e.KeyChar == (char)Keys.Back) return true;
                if (textBox.Text.Contains(",") && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' && !textBox.Text.Contains(","))
                {
                    e.Handled = true;
                    textBox.Text += ",";
                    textBox.SelectionStart = textBox.Text.Length;
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public static float GetBaseImponible(float total, string porcentaje)
        {
            if (porcentaje == "Exento")
            {
                return 0;
            }

            float impuesto = Convert.ToInt32(porcentaje.Replace("%", ""));
            float impuestoASumar = (impuesto + 100) / 100;
            return total / impuestoASumar;
        }

        public static float GetIVA(float total, string porcentaje)
        {
            if (porcentaje == "Exento")
            {
                return 0;
            }

            float impuesto = Convert.ToInt32(porcentaje.Replace("%", ""));
            float baseImponible = GetBaseImponible(total, porcentaje);

            return baseImponible * (impuesto / 100);
        }
    }
}
