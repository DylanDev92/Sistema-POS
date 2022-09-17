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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRestProduct(false);
        }

        private void SortListProducts()
        {
            //try
            //{
            //    Database.TemporaryData.CarritoLista = null;
            //    Database.TemporaryData.CarritoLista = (BindingList<Database.ProductTemp>)Database.TemporaryData.CarritoLista.Reverse();
            //}
            //catch { }
            //if (dataGridViewFacturacion.Columns["Cantidad"] != null)
            //{
            //    dataGridViewFacturacion.Sort(dataGridViewFacturacion.Columns["Cantidad"], ListSortDirection.Descending);
            //}

            
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {

            dataGridViewFacturacion.AutoGenerateColumns = false;

            dataGridViewFacturacion.Columns["Codigo"].DataPropertyName = "Codigo";
            dataGridViewFacturacion.Columns["Descripcion"].DataPropertyName = "ProductoNombre";
            dataGridViewFacturacion.Columns["Cantidad"].DataPropertyName = "Cantidad";
            dataGridViewFacturacion.Columns["PrecioTotal"].DataPropertyName = "PrecioTotal";
            dataGridViewFacturacion.Columns["PrecioU"].DataPropertyName = "PrecioUnitario";
            dataGridViewFacturacion.Columns["PrecioTotal"].DefaultCellStyle.Format = "N2";
            dataGridViewFacturacion.Columns["PrecioU"].DefaultCellStyle.Format = "N2";
            dataGridViewFacturacion.DataSource = Database.TemporaryData.CarritoLista;

            SortListProducts();
        }

        private void Facturacion_Shown(object sender, EventArgs e)
        {
            textBoxInputCode.Focus();
            ActualizarTotal();

            if (Database.TasaDolar.IsToDollar == true)
            {
                labelSwapLeft.Text = "Bolivares";
                labelSwapRight.Text = "Dólares";
            }
            else
            {
                labelSwapRight.Text = "Bolivares";
                labelSwapLeft.Text = "Dólares";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxInputCode_TextChanged(object sender, EventArgs e)
        {

        }


        private string SelectedProductID { get; set; }
        private string SelectedProductNombre { get; set; }
        private void SelectRow(string codigo, string nombre)
        {
            dataGridViewFacturacion.ClearSelection();

            foreach (DataGridViewRow row in dataGridViewFacturacion.Rows)
            {
                if (row.Cells[1].Value.ToString() == codigo && row.Cells[2].Value.ToString() == nombre)
                { 
                    row.Selected = true;

                    dataGridViewFacturacion.FirstDisplayedScrollingRowIndex = row.Index;

                    SelectedProductID = row.Cells[1].Value.ToString();
                    SelectedProductNombre = row.Cells[2].Value.ToString();

                    return;
                }
            }
        }

        private void textBoxInputCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    if (!Database.Products.ProductsList.Any(x => x.Codigo == textBoxInputCode.Text))
                    {
                        new Mensaje("Producto inexistente", "El código de este producto no está registrado").ShowDialog();
                        textBoxInputCode.Clear();
                        return;
                    }
                    else
                    {
                        if (!Database.TemporaryData.CarritoLista.Any(x => x.Codigo == textBoxInputCode.Text))
                        {
                            Database.Product product = Database.Products.ProductsList.Where(x => x.Codigo == textBoxInputCode.Text).First();

                            Database.ProductTemp productTemp = new Database.ProductTemp
                            {
                                IVA = product.IVA,
                                BaseImponible = product.BaseImponible,
                                Codigo = product.Codigo,
                                Exento = product.Exento,
                                Impuesto = product.Impuesto,
                                NoPrecio = product.NoPrecio,
                                Peso = product.Peso,
                                PrecioDolar = product.PrecioDolar,
                                ProductoNombre = product.ProductoNombre,
                                PrecioUnitario = product.PrecioTotal,
                                Cantidad = 1,
                                PrecioTotal = product.PrecioTotal
                            };

                            float precioCustom = 0;
                            float pesoCustom = 0;

                            if (product.NoPrecio == true)
                            {
                                Input inputPrecio = new Input("Introduce un precio");
                                inputPrecio.ShowDialog();
                                if (inputPrecio.DialogResult == DialogResult.OK)
                                {
                                    precioCustom = inputPrecio.Cantidad;
                                }
                                else
                                {
                                    textBoxInputCode.Clear();
                                    return;
                                }
                                productTemp.PrecioUnitario = precioCustom;
                                if (productTemp.Impuesto == "Exento")
                                {
                                    productTemp.Exento = precioCustom;
                                }
                                else
                                {
                                    productTemp.IVA = Fun.GetIVA(precioCustom, productTemp.Impuesto.Replace("%", ""));
                                    productTemp.IVA = Fun.GetBaseImponible(precioCustom, productTemp.Impuesto.Replace("%", ""));
                                }
                            }
                            if (product.Peso == true)
                            {
                                Input inputPeso = new Input("Introduce un peso KG");
                                inputPeso.ShowDialog();
                                if (inputPeso.DialogResult == DialogResult.OK)
                                {
                                    pesoCustom = inputPeso.Cantidad;
                                }
                                else
                                {
                                    textBoxInputCode.Clear();
                                    return;
                                }
                                productTemp.Cantidad = pesoCustom;
                            }

                            productTemp.PrecioTotal = productTemp.PrecioUnitario * productTemp.Cantidad;

                            Database.TemporaryData.CarritoLista.Add(productTemp);

                            SelectRow(textBoxInputCode.Text, productTemp.ProductoNombre);
                        }
                        else
                        {
                            Database.ProductTemp addTemp = Database.TemporaryData.CarritoLista.Where(x => x.Codigo == textBoxInputCode.Text).First();

                            if (addTemp.NoPrecio == false)
                            {
                                Database.TemporaryData.CarritoLista.Remove(Database.TemporaryData.CarritoLista.Where(x => x.Codigo == textBoxInputCode.Text).First());

                                float cantidad = addTemp.Cantidad;

                                if (addTemp.Peso == true)
                                {
                                    Input inputPeso = new Input("Introduce un peso KG");
                                    inputPeso.ShowDialog();
                                    if (inputPeso.DialogResult == DialogResult.OK)
                                    {
                                        cantidad = inputPeso.Cantidad + cantidad;
                                    }
                                    else
                                    {
                                        textBoxInputCode.Clear();
                                        return;
                                    }
                                    addTemp.Cantidad = cantidad;
                                }
                                else
                                {
                                    cantidad++;
                                    addTemp.Cantidad = cantidad;
                                }

                                addTemp.PrecioTotal = addTemp.PrecioUnitario * cantidad;

                                Database.TemporaryData.CarritoLista.Add(addTemp);
                                SelectRow(textBoxInputCode.Text, addTemp.ProductoNombre);
                            }
                            else
                            {
                                Database.Product product = Database.Products.ProductsList.Where(x => x.Codigo == textBoxInputCode.Text).First();

                                Database.ProductTemp productTemp = new Database.ProductTemp
                                {
                                    IVA = product.IVA,
                                    BaseImponible = product.BaseImponible,
                                    Codigo = product.Codigo,
                                    Exento = product.Exento,
                                    Impuesto = product.Impuesto,
                                    NoPrecio = product.NoPrecio,
                                    Peso = product.Peso,
                                    PrecioDolar = product.PrecioDolar,
                                    ProductoNombre = product.ProductoNombre + Database.TemporaryData.CarritoLista.Count(x => x.Codigo == textBoxInputCode.Text).ToString(),
                                    PrecioUnitario = product.PrecioTotal,
                                    Cantidad = 1,
                                    PrecioTotal = product.PrecioTotal
                                };

                                float precioCustom = 0;
                                float pesoCustom = 0;

                                if (product.NoPrecio == true)
                                {
                                    Input inputPrecio = new Input("Introduce un precio");
                                    inputPrecio.ShowDialog();
                                    if (inputPrecio.DialogResult == DialogResult.OK)
                                    {
                                        precioCustom = inputPrecio.Cantidad;
                                    }
                                    else
                                    {
                                        textBoxInputCode.Clear();
                                        return;
                                    }
                                    productTemp.PrecioUnitario = precioCustom;
                                    if (productTemp.Impuesto == "Exento")
                                    {
                                        productTemp.Exento = precioCustom;
                                    }
                                    else
                                    {
                                        productTemp.IVA = Fun.GetIVA(precioCustom, productTemp.Impuesto.Replace("%", ""));
                                        productTemp.IVA = Fun.GetBaseImponible(precioCustom, productTemp.Impuesto.Replace("%", ""));
                                    }
                                }
                                if (product.Peso == true)
                                {
                                    Input inputPeso = new Input("Introduce un peso KG");
                                    inputPeso.ShowDialog();
                                    if (inputPeso.DialogResult == DialogResult.OK)
                                    {
                                        pesoCustom = inputPeso.Cantidad;
                                    }
                                    else
                                    {
                                        textBoxInputCode.Clear();
                                        return;
                                    }
                                    productTemp.Cantidad = pesoCustom;
                                }

                                productTemp.PrecioTotal = productTemp.PrecioUnitario * productTemp.Cantidad;

                                Database.TemporaryData.CarritoLista.Add(productTemp);
                                SelectRow(textBoxInputCode.Text, productTemp.ProductoNombre);
                            }
                        }
                    }
                    textBoxInputCode.ResetText();
                }
                catch { }
                finally
                {
                    ActualizarTotal();
                }
            }
        }

        private void buttonBorrarLista_Click(object sender, EventArgs e)
        {
            Desicion desicion = new Desicion("Borrar lista", "Se borrará toda la lista de facturación");
            desicion.ShowDialog();
            if (desicion.DialogResult == DialogResult.OK)
            {
                Database.TemporaryData.CarritoLista.Clear();
                Database.TemporaryData.PayTemps.Clear();
            }
        }

        private void AddRestProduct(bool toAdd)
        {
            try
            {
                if (Database.TemporaryData.CarritoLista.Any(x => x.Codigo == SelectedProductID))
                {
                    Database.ProductTemp addTemp = Database.TemporaryData.CarritoLista.Where(x => x.Codigo == SelectedProductID && x.ProductoNombre == SelectedProductNombre).First();

                    Database.TemporaryData.CarritoLista.Remove(Database.TemporaryData.CarritoLista.Where(x => x.Codigo == SelectedProductID && x.ProductoNombre == SelectedProductNombre).First());
                    float cantidad = addTemp.Cantidad;
                    if (addTemp.Peso == true)
                    {
                        Input inputPeso = new Input("Añadir peso KG");
                        inputPeso.ShowDialog();
                        if (inputPeso.DialogResult == DialogResult.OK)
                        {
                            cantidad = addTemp.Cantidad + inputPeso.Cantidad;
                        }
                    }
                    else
                    {
                        cantidad++;
                    }

                    if (toAdd == true)
                    {
                        addTemp.Cantidad = cantidad;
                    }
                    else
                    {
                        cantidad = 1;
                        if (addTemp.Cantidad < cantidad)
                        {
                            addTemp.Cantidad = 0;
                            return;
                        }
                        else
                        {
                            addTemp.Cantidad--;
                        }

                        if (addTemp.Cantidad == 0) return;
                    }

                    addTemp.PrecioTotal = addTemp.PrecioUnitario * addTemp.Cantidad;

                    Database.TemporaryData.CarritoLista.Add(addTemp);
                    SelectRow(SelectedProductID, SelectedProductNombre);
                }
            }
            catch { }
            finally
            {
                ActualizarTotal();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F5)
            {
                Desicion desicion = new Desicion("Borrar lista", "Se borrará toda la lista de facturación");
                desicion.ShowDialog();
                if (desicion.DialogResult == DialogResult.OK)
                {
                    Database.TemporaryData.CarritoLista.Clear();
                }
            }
            if (keyData == Keys.Add || keyData == Keys.Oemplus)
            {
                if (!string.IsNullOrEmpty(SelectedProductID))
                {
                    AddRestProduct(true);
                    return true;
                }
            }
            if (keyData == Keys.Subtract || keyData == Keys.OemMinus)
            {
                if (!string.IsNullOrEmpty(SelectedProductID))
                {
                    AddRestProduct(false);
                    return true;
                }
            }
            if (keyData == Keys.Multiply)
            {
                buttonMultiplicar_Click();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void dataGridViewFacturacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SelectedProductID = dataGridViewFacturacion.SelectedRows[0].Cells[1].Value.ToString();
                SelectedProductNombre = dataGridViewFacturacion.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch { }
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            AddRestProduct(true);
        }

        private void buttonMultiplicar_Click(object sender = null, EventArgs e = null)
        {
            try
            {
                if (Database.TemporaryData.CarritoLista.Any(x => x.Codigo == SelectedProductID))
                {
                    Database.ProductTemp addTemp = Database.TemporaryData.CarritoLista.Where(x => x.Codigo == SelectedProductID && x.ProductoNombre == SelectedProductNombre).First();

                    float cantidad = addTemp.Cantidad;
                    Input inputCantidad = new Input("Introducir cantidad");

                    inputCantidad.ShowDialog();
                    if (inputCantidad.DialogResult == DialogResult.OK)
                    {
                        addTemp.Cantidad = inputCantidad.Cantidad;
                    }
                    else
                    {
                        return;
                    }

                    addTemp.PrecioTotal = addTemp.PrecioUnitario * addTemp.Cantidad;
                    Database.TemporaryData.CarritoLista.Remove(Database.TemporaryData.CarritoLista.Where(x => x.Codigo == SelectedProductID && x.ProductoNombre == SelectedProductNombre).First());

                    if (addTemp.Cantidad <= 0) return;
                    
                    Database.TemporaryData.CarritoLista.Add(addTemp);
                    SelectRow(SelectedProductID, SelectedProductNombre);
                }
            }
            catch { }
            finally
            {
                ActualizarTotal();
            }
        }

        private void ActualizarTotal()
        {
            int articulos = 0;
            float totalDolar = 0;
            float total = 0;
            float totalIVA = 0;

            foreach (Database.ProductTemp product in Database.TemporaryData.CarritoLista)
            {
                if (product.Peso == true)
                {
                    articulos++;
                }
                else
                {
                    articulos += Convert.ToInt32(product.Cantidad);
                }
                totalDolar += (product.PrecioTotal / Database.TasaDolar.Tasa);
                total += (product.PrecioTotal);
                totalIVA += (product.IVA * product.Cantidad);
            }
            if (Database.TasaDolar.IsToDollar == false)
            {
                labelArticulos.Text = "Articulos: " + articulos.ToString();
                labelIVA.Text = "IVA: " + totalIVA.ToString("N2");
                labelTotal.Text = total.ToString("N2");
                label1.Text = totalDolar.ToString("N2");
            }
            else
            {
                labelArticulos.Text = "Articulos: " + articulos.ToString();
                labelIVA.Text = "IVA: " + (totalIVA / Database.TasaDolar.Tasa).ToString("N2");
                labelTotal.Text = (total / Database.TasaDolar.Tasa).ToString("N2");
                label1.Text = total.ToString("N2");
            }
        }

        private void dataGridViewFacturacion_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarTotal();
            SortListProducts();
        }

        private void dataGridViewFacturacion_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarTotal();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (dataGridViewFacturacion.Rows.Count > 0)
            {
                try
                {
                    SelectRow(dataGridViewFacturacion.Rows[dataGridViewFacturacion.SelectedRows[0].Index - 1].Cells[1].Value.ToString(), dataGridViewFacturacion.Rows[dataGridViewFacturacion.SelectedRows[0].Index - 1].Cells[2].Value.ToString());
                }
                catch { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewFacturacion.Rows.Count > 0)
            {
                try
                {
                    SelectRow(dataGridViewFacturacion.Rows[dataGridViewFacturacion.SelectedRows[0].Index + 1].Cells[1].Value.ToString(), dataGridViewFacturacion.Rows[dataGridViewFacturacion.SelectedRows[0].Index + 1].Cells[2].Value.ToString());
                }
                catch { }
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            if (dataGridViewFacturacion.Rows.Count > 0)
            {
                try
                {
                    SelectRow(dataGridViewFacturacion.Rows[dataGridViewFacturacion.SelectedRows[0].Index - 1].Cells[1].Value.ToString(), dataGridViewFacturacion.Rows[dataGridViewFacturacion.SelectedRows[0].Index - 1].Cells[2].Value.ToString());
                }
                catch { }
            }
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            if (Database.TasaDolar.IsToDollar == false)
            {
                labelSwapLeft.Text = "Bolivares";
                labelSwapRight.Text = "Dólares";

                Database.TasaDolar.IsToDollar = true;
            }
            else
            {
                labelSwapRight.Text = "Bolivares";
                labelSwapLeft.Text = "Dólares";

                Database.TasaDolar.IsToDollar = false;
            }

            ActualizarTotal();
        }
    }
}
