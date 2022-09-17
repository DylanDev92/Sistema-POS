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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            dataGridViewProductos.AutoGenerateColumns = false;

            dataGridViewProductos.Columns["Codigo"].DataPropertyName = "Codigo";
            dataGridViewProductos.Columns["Descripcion"].DataPropertyName = "ProductoNombre";
            dataGridViewProductos.Columns["Precio"].DataPropertyName = "PrecioTotal";

            dataGridViewProductos.Columns["Precio"].DefaultCellStyle.Format = "N2";
            dataGridViewProductos.DataSource = Database.Products.ProductsList;
        }

        private void RestoreFields(bool restoreCode = true)
        {
            comboBoxImpuestos.Text = comboBoxImpuestos.Items[0].ToString();
            checkBoxNoPrecio.Checked = false;
            checkBoxPeso.Checked = false;
            textBoxBolivares.ResetText();
            if (restoreCode == true)
            {
                textBoxCodigo.ResetText();
            }
            textBoxDescripcion.ResetText();
            textBoxDolares.ResetText();

            ActualizarValores();
        }

        private void Productos_Shown(object sender, EventArgs e)
        {
            RestoreFields();
            textBoxInputCode.Focus();
        }

        private void textBoxInputCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            RestoreFields();
        }

        private void textBoxCodigo_Enter(object sender, EventArgs e)
        {
            //RestoreFields();
        }

        private void textBoxInputCode_Enter(object sender, EventArgs e)
        {
            textBoxInputCode.ResetText();
        }

        private void textBoxBolivares_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Fun.CheckCommaInTextbox(e, textBoxBolivares)) return;

            ActualizarValores();
        }

        private void textBoxDolares_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxDolares_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Fun.CheckCommaInTextbox(e, textBoxDolares)) return;
        }

        private void comboBoxImpuestos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxDolares_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Fun.CheckCommaInTextbox(e, textBoxDolares)) return;

            ActualizarValores();
        }

        private void textBoxDolares_Leave(object sender, EventArgs e)
        {
            try
            {
                textBoxDolares.Text = float.Parse(textBoxDolares.Text).ToString("0.00");
            }
            catch { }

            ActualizarValores();
        }

        private void textBoxBolivares_Leave(object sender, EventArgs e)
        {
            try
            {
                textBoxBolivares.Text = float.Parse(textBoxBolivares.Text).ToString("0.00");
            }
            catch { }

            ActualizarValores();
        }

        private void ActualizarValores()
        {
            if (string.IsNullOrEmpty(textBoxDolares.Text))
            {
                textBoxDolares.Text = "0,00";
            }
            if (string.IsNullOrEmpty(textBoxBolivares.Text))
            {
                textBoxBolivares.Text = "0,00";
            }

            if (float.Parse(textBoxDolares.Text) == 0.00f)
            {
                labelTotal.Text = "Total: " + float.Parse(textBoxBolivares.Text).ToString("N2");

                if (comboBoxImpuestos.Text == "Exento")
                {
                    labelBaseImponible.Text = "Base: 0,00";
                    labelIVA.Text = "IVA: 0,00";
                    labelExento.Text = "Exento: " + float.Parse(textBoxBolivares.Text).ToString("N2");
                    labelDolares.Text = "Dólares: " + float.Parse(textBoxDolares.Text).ToString("N2");
                }
                else
                {
                    labelBaseImponible.Text = "Base: " + Fun.GetBaseImponible(float.Parse(textBoxBolivares.Text), comboBoxImpuestos.Text).ToString("N2");
                    labelIVA.Text = "IVA: " + Fun.GetIVA(float.Parse(textBoxBolivares.Text), comboBoxImpuestos.Text).ToString("N2");
                    labelExento.Text = "Exento: " + "0,00";
                    labelDolares.Text = "Dólares: " + float.Parse(textBoxDolares.Text).ToString("N2");
                }
            }
            else
            {
                float tasa = Database.TasaDolar.Tasa;

                labelTotal.Text = "Total: " + (float.Parse(textBoxDolares.Text) * tasa).ToString("N2");

                if (comboBoxImpuestos.Text == "Exento")
                {
                    labelBaseImponible.Text = "Base: " + "0,00";
                    labelIVA.Text = "IVA: " + "0,00";
                    labelExento.Text = "Exento: " + (float.Parse(textBoxDolares.Text) * tasa).ToString("N2");
                    labelDolares.Text = "Dólares: " + float.Parse(textBoxDolares.Text).ToString("N2");
                }
                else
                {
                    labelBaseImponible.Text = "Base: " + Fun.GetBaseImponible((float.Parse(textBoxDolares.Text) * tasa), comboBoxImpuestos.Text).ToString("N2");
                    labelIVA.Text = "IVA: " + Fun.GetIVA((float.Parse(textBoxDolares.Text) * tasa), comboBoxImpuestos.Text).ToString("N2");
                    labelExento.Text = "Exento: " + "0,00";
                    labelDolares.Text = "Dólares: " + float.Parse(textBoxDolares.Text).ToString("N2");
                }
            }
        }

        private void textBoxBolivares_Enter(object sender, EventArgs e)
        {
            if (float.Parse(textBoxBolivares.Text) == 0.00f)
            {
                textBoxBolivares.ResetText();
            }
        }

        private void textBoxDolares_Enter(object sender, EventArgs e)
        {
            if (float.Parse(textBoxDolares.Text) == 0.00f)
            {
                textBoxDolares.ResetText();
            }
        }

        private void comboBoxImpuestos_SelectedValueChanged(object sender, EventArgs e)
        {
            ActualizarValores();
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBolivares.Text) || string.IsNullOrEmpty(textBoxCodigo.Text) || string.IsNullOrEmpty(textBoxDolares.Text) || string.IsNullOrEmpty(textBoxDescripcion.Text))
            {
                new Mensaje("Incompleto", "Rellene todos los campos.").ShowDialog();
                textBoxCodigo.Focus();
                return;
            }
            else if (float.Parse(textBoxDolares.Text) == 0.00f && float.Parse(textBoxBolivares.Text) == 0.00f)
            {
                new Mensaje("Incompleto", "Rellene todos los campos.").ShowDialog();
                textBoxCodigo.Focus();
                return;
            }

            string added = "añadido";

            if (Database.Products.ProductsList.Any(x => x.Codigo == textBoxCodigo.Text.Trim()))
            {
                Database.Products.ProductsList.Remove(Database.Products.ProductsList.Where(x => x.Codigo == textBoxCodigo.Text.Trim()).First());
                added = "actualizado";
            }

            if (!Database.Products.ProductsList.Any(x => x.Codigo == textBoxCodigo.Text.Trim()))
            {
                Database.Product product = new Database.Product();

                product.NoPrecio = checkBoxNoPrecio.Checked;
                product.Peso = checkBoxPeso.Checked;
                product.Impuesto = comboBoxImpuestos.Text;
                product.ProductoNombre = textBoxDescripcion.Text;
                product.Codigo = textBoxCodigo.Text;

                if (float.Parse(textBoxDolares.Text) == 0.00f)
                {
                    product.PrecioTotal = float.Parse(textBoxBolivares.Text);

                    if (comboBoxImpuestos.Text == "Exento")
                    {
                        product.BaseImponible = 0.00f;
                        product.IVA = 0.00f;
                        product.Exento = float.Parse(textBoxBolivares.Text);
                        product.PrecioDolar = float.Parse(textBoxDolares.Text);
                    }
                    else
                    {
                        product.BaseImponible = Fun.GetBaseImponible(float.Parse(textBoxBolivares.Text), comboBoxImpuestos.Text);
                        product.IVA = Fun.GetIVA(float.Parse(textBoxBolivares.Text), comboBoxImpuestos.Text);
                        product.Exento = 0.00f;
                        product.PrecioDolar = float.Parse(textBoxDolares.Text);
                    }
                }
                else
                {
                    float tasa = Database.TasaDolar.Tasa;

                    product.PrecioTotal = float.Parse(textBoxDolares.Text) * tasa;

                    if (comboBoxImpuestos.Text == "Exento")
                    {
                        product.BaseImponible = 0.00f;
                        product.IVA = 0.00f;
                        product.Exento = float.Parse(textBoxDolares.Text) * tasa;
                        product.PrecioDolar = float.Parse(textBoxDolares.Text);
                    }
                    else
                    {
                        product.BaseImponible = Fun.GetBaseImponible((float.Parse(textBoxDolares.Text) * tasa), comboBoxImpuestos.Text);
                        product.IVA = Fun.GetIVA((float.Parse(textBoxDolares.Text) * tasa), comboBoxImpuestos.Text);
                        product.Exento = 0.00f;
                        product.PrecioDolar = float.Parse(textBoxDolares.Text);
                    }
                }

                Database.Products.ProductsList.Add(product);
            }

            Database.Products.Save();
            new Mensaje("Actualizado correctamente", "Se ha " + added + " el producto " + textBoxDescripcion.Text).ShowDialog();
            RestoreFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Database.Products.ProductsList.Any(x => x.Codigo == textBoxCodigo.Text.Trim()))
                {
                    Database.Product product = Database.Products.ProductsList.Where(x => x.Codigo == textBoxCodigo.Text.Trim()).First();

                    new Mensaje("Borrado correctamente", "Se ha borrado el producto " + product.ProductoNombre).ShowDialog();

                    Database.Products.ProductsList.Remove(product);

                    Database.Products.Save();
                }
                else
                {
                    new Mensaje("Error al borrar", "Este producto no se encuentra registrado").ShowDialog();
                }
            }
            catch
            {
                new Mensaje("Error al borrar", "No se pudo borrar el producto").ShowDialog();
            }

            ActualizarValores();
            RestoreFields();
        }

        private string SelectedProductDG { get; set; }
        private void dataGridViewProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Desicion desicion = new Desicion("Editar producto", "¿Desea editar " + dataGridViewProductos.SelectedRows[0].Cells[1].Value.ToString() + "?");
            desicion.ShowDialog();
            if (desicion.DialogResult == DialogResult.OK)
            {
                SelectedProductDG = dataGridViewProductos.SelectedRows[0].Cells[0].Value.ToString();

                Database.Product product = Database.Products.ProductsList.Where(x => x.Codigo == SelectedProductDG).First();

                comboBoxImpuestos.Text = product.Impuesto;
                checkBoxNoPrecio.Checked = product.NoPrecio;
                checkBoxPeso.Checked = product.Peso;
                textBoxBolivares.Text = product.PrecioTotal.ToString("0.00");
                textBoxCodigo.Text = product.Codigo;
                textBoxDescripcion.Text = product.ProductoNombre;
                textBoxDolares.Text = product.PrecioDolar.ToString("0.00");

                ActualizarValores();
            }

            return;
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            RestoreFields();
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

        private void textBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (Database.Products.ProductsList.Any(x => x.Codigo == textBoxCodigo.Text.Trim()))
                {
                    Database.Product product = Database.Products.ProductsList.Where(x => x.Codigo == textBoxCodigo.Text).First();

                    comboBoxImpuestos.Text = product.Impuesto;
                    checkBoxNoPrecio.Checked = product.NoPrecio;
                    checkBoxPeso.Checked = product.Peso;
                    textBoxBolivares.Text = product.PrecioTotal.ToString("0.00");
                    textBoxCodigo.Text = product.Codigo;
                    textBoxDescripcion.Text = product.ProductoNombre;
                    textBoxDolares.Text = product.PrecioDolar.ToString("0.00");
                }
                else
                {
                    RestoreFields(false);
                }
            }
        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
