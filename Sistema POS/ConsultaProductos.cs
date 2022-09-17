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
    public partial class ConsultaProductos : Form
    {
        public ConsultaProductos()
        {
            InitializeComponent();
        }

        private void ConsultaProductos_Shown(object sender, EventArgs e)
        {
            textBoxInputCode.Focus();
        }

        private void ConsultaProductos_Load(object sender, EventArgs e)
        {
            dataGridViewProductos.AutoGenerateColumns = false;

            dataGridViewProductos.Columns["Codigo"].DataPropertyName = "Codigo";
            dataGridViewProductos.Columns["Descripcion"].DataPropertyName = "ProductoNombre";
            dataGridViewProductos.Columns["Precio"].DataPropertyName = "PrecioTotal";

            dataGridViewProductos.Columns["Precio"].DefaultCellStyle.Format = "N2";
            dataGridViewProductos.DataSource = Database.Products.ProductsList;
        }

        private void textBoxInputCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxInputCode.Text))
            {
                dataGridViewProductos.DataSource = Database.Products.ProductsList;
                return;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                textBoxInputCode.Clear();
            }

            dataGridViewProductos.DataSource = new BindingList<Database.Product>(Database.Products.ProductsList.ToList().FindAll(x => x.Codigo.ToLower().Contains(textBoxInputCode.Text.ToLower()) || x.ProductoNombre.ToLower().Contains(textBoxInputCode.Text.ToLower())));

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    Database.Product product = Database.Products.ProductsList.Where(x => x.Codigo.ToLower().Contains(textBoxInputCode.Text) || x.ProductoNombre.ToLower().Contains(textBoxInputCode.Text.ToLower())).First();

                    float convertBolivar = 0;

                    if (product.PrecioDolar == 0.00f)
                    {
                        convertBolivar = product.PrecioTotal;
                    }
                    else
                    {
                        convertBolivar = product.PrecioDolar * Database.TasaDolar.Tasa;
                    }

                    labelTotal.Text = "Total: " + convertBolivar.ToString("N2");
                    labelCodigoProducto.Text = product.Codigo;
                    labelNameProduct.Text = product.ProductoNombre;
                    labelDolares.Text = "Dólares: " + product.PrecioDolar.ToString("N2");

                    labelBaseImponible.Text = "Base: " + Fun.GetBaseImponible((convertBolivar), product.Impuesto).ToString("N2");
                    labelIVA.Text = "IVA: " + Fun.GetIVA((convertBolivar), product.Impuesto).ToString("N2");
                    labelExento.Text = "Exento: " + product.Exento.ToString("N2");
                }
                catch { }
            }
        }

        private string SelectedProductDG { get; set; }
        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedProductDG = dataGridViewProductos.SelectedRows[0].Cells[0].Value.ToString();

            Database.Product product = Database.Products.ProductsList.Where(x => x.Codigo == SelectedProductDG).First();

            float convertBolivar = 0;

            if (product.PrecioDolar == 0.00f)
            {
                convertBolivar = product.PrecioTotal;
            }
            else
            {
                convertBolivar = product.PrecioDolar * Database.TasaDolar.Tasa;
            }

            labelTotal.Text = "Total: " + convertBolivar.ToString("N2");
            labelCodigoProducto.Text = product.Codigo;
            labelNameProduct.Text = product.ProductoNombre;
            labelDolares.Text = "Dólares: " + product.PrecioDolar.ToString("N2");

            labelBaseImponible.Text = "Base: " + Fun.GetBaseImponible((convertBolivar), product.Impuesto).ToString("N2");
            labelIVA.Text = "IVA: " + Fun.GetIVA((convertBolivar), product.Impuesto).ToString("N2");
            labelExento.Text = "Exento: " + product.Exento.ToString("N2");
        }

        private void textBoxInputCode_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxInputCode.Text))
            {
                dataGridViewProductos.DataSource = Database.Products.ProductsList;
                return;
            }

            dataGridViewProductos.DataSource = new BindingList<Database.Product>(Database.Products.ProductsList.ToList().FindAll(x => x.Codigo.ToLower().Contains(textBoxInputCode.Text.ToLower()) || x.ProductoNombre.ToLower().Contains(textBoxInputCode.Text.ToLower())));
        }
    }
}
