using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_POS
{
    public partial class TasaDolar : Form
    {
        public TasaDolar()
        {
            InitializeComponent();
        }

        

        private void buttonSwap_Click(object sender, EventArgs e)
        {

        }

        private void TasaDolar_Shown(object sender, EventArgs e)
        {
            textBoxInputTasa.Text = Database.TasaDolar.Tasa.ToString("N2");

            dataGridViewDolares.Columns["Multiplicacion"].DataPropertyName = "Multiplicacion";
            dataGridViewDolares.Columns["Total"].DataPropertyName = "Total";

            dataGridViewDolares.Columns["Total"].DefaultCellStyle.Format = "N2";
            dataGridViewDolares.DataSource = Database.TasaDolar.TasaList;
        }

        private void textBoxInputTasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Fun.CheckCommaInTextbox(e, textBoxInputTasa)) return;

            if (e.KeyChar != (char)Keys.Enter) return;

            Database.TasaDolar.UpdateTasa(float.Parse(textBoxInputTasa.Text));

            MessageBox.Show("Se ha actualizado la tasa");
        }

        private void textBoxDolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Fun.CheckCommaInTextbox(e, textBoxDolar)) return;

            if (e.KeyChar != (char)Keys.Enter) return;

            if (IsBolivarToDollar == false)
            {
                textBoxBolivar.Text = (float.Parse(textBoxDolar.Text) * Database.TasaDolar.Tasa).ToString("N2");
            }
            else
            {
                textBoxBolivar.Text = (float.Parse(textBoxDolar.Text) / Database.TasaDolar.Tasa).ToString("N2");
            }
        }

        private void textBoxBolivar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Fun.CheckCommaInTextbox(e, textBoxBolivar)) return;
        }

        private bool IsBolivarToDollar { get; set; } = false;

        private void buttonSwap_Click_1(object sender, EventArgs e)
        {
            if (IsBolivarToDollar == false)
            {
                IsBolivarToDollar = true;

                labelDol.Text = "Bolívar";
                labelBol.Text = "Dólar";
            }
            else
            {
                IsBolivarToDollar = false;
                labelBol.Text = "Bolívar";
                labelDol.Text = "Dólar";
            }
            textBoxBolivar.ResetText();
            textBoxDolar.ResetText();
            textBoxDolar.Focus();
        }
    }
}
