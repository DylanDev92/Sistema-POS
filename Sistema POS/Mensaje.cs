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
    public partial class Mensaje : Form
    {
        public Mensaje(string mensajeBreve, string mensajeDetallado)
        {
            InitializeComponent();

            labelTextoBreve.Text = mensajeBreve;
            label1.Text = mensajeDetallado;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
