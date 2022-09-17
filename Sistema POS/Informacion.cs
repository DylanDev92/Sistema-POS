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
    public partial class Informacion : Form
    {
        public Informacion()
        {
            InitializeComponent();
        }

        private void buttonFacturar_Click(object sender, EventArgs e)
        {
            if (textBoxDireccion.Text == "" || textBoxNombre.Text == "" || textBoxRIF.Text == "" || textBoxTelefono.Text == "")
            {
                new Mensaje("Rellena todos los campos", "Rellena los campos vacios requeridos").ShowDialog();
            }
            else
            {
                new Mensaje("Actualizacion satisfactoria", "Se han actualizado satisfactoriamente los datos a imprimir").ShowDialog();
                Print.SaveInformation(textBoxRIF.Text, textBoxNombre.Text, textBoxDireccion.Text, textBoxTelefono.Text);
            }
        }

        private void Informacion_Load(object sender, EventArgs e)
        {
            textBoxDireccion.Text = Print.Informacion.Direccion;
            textBoxNombre.Text = Print.Informacion.NombreEmpresa;
            textBoxRIF.Text = Print.Informacion.RIF;
            textBoxTelefono.Text = Print.Informacion.Telefono;
        }
    }
}
