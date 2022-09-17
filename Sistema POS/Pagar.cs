using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.xmp;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;

namespace Sistema_POS
{
    public partial class Pagar : Form
    {
        public Pagar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.MainFormInteract.PutInContainer(new Facturacion());
            this.Close();
        }

        public float Total { get; set; }

        private void Pagar_Load(object sender, EventArgs e)
        {
            if (Database.TemporaryData.CarritoLista.Count == 0)
            {
                Database.TemporaryData.PayTemps.Clear();
            }

            BindingList<Database.ProductTemp> products = Database.TemporaryData.CarritoLista;
            float total = 0;

            List<ProductData> productDatas = new List<ProductData>();

            foreach (var producto in products)
            {
                total = total + producto.PrecioTotal;

                productDatas.Add(new ProductData
                {
                    Codigo = producto.Codigo,
                    Descripcion = producto.ProductoNombre + " x " + producto.Cantidad,
                    PrecioTotal = producto.PrecioTotal
                });
            }

            Total = total;
            textBoxTotal.Text = total.ToString("N2");

            RefreshPay();

            dataGridViewProductos.AutoGenerateColumns = false;

            dataGridViewProductos.Columns["Codigo"].DataPropertyName = "Codigo";
            dataGridViewProductos.Columns["Descripcion"].DataPropertyName = "Descripcion";
            dataGridViewProductos.Columns["PrecioTotal"].DataPropertyName = "PrecioTotal";
            dataGridViewProductos.Columns["PrecioTotal"].DefaultCellStyle.Format = "N2";

            dataGridViewProductos.DataSource = productDatas;


            dataGridViewPaid.AutoGenerateColumns = false;
            dataGridViewPaid.Columns["PayMethod"].DataPropertyName = "PayMethod";
            dataGridViewPaid.Columns["Amount"].DataPropertyName = "Amount";
            dataGridViewPaid.Columns["Amount"].DefaultCellStyle.Format = "N2";
            dataGridViewPaid.DataSource = Database.TemporaryData.PayTemps;
        }

        public float Pagado { get; set; }

        private void RefreshPay()
        {
            float pagado = 0;

            foreach (var pago in Database.TemporaryData.PayTemps)
            {
                pagado = pagado + pago.Amount;
            }

            textBoxRestante.Text = (Total - pagado).ToString("N2");

            if (pagado < Total)
            {
                textBoxRestante.BackColor = Color.LightCoral;
            }
            else
            {
                textBoxRestante.BackColor = Color.LightGreen;
            }

            Pagado = pagado;
        }

        public class ProductData
        {
            public string Codigo { get; set; }
            public string Descripcion { get; set; }
            public float PrecioTotal { get; set; }
        }

        private void buttonDebit_Click(object sender, EventArgs e)
        {
            Input input = new Input("Pagar con Débito", Total - Pagado);
            input.ShowDialog();
            if (input.DialogResult == DialogResult.OK)
            {
                Database.TemporaryData.PayTemps.Add(new Database.PayTemp
                {
                    PayMethod = "Debito",
                    Amount = input.Cantidad
                });
            }
            RefreshPay();
        }

        private void dataGridViewPaid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Database.TemporaryData.PayTemps.Remove(Database.TemporaryData.PayTemps.Where(x => x.PayMethod == dataGridViewPaid.SelectedRows[0].Cells[0].Value.ToString() && x.Amount.ToString() == dataGridViewPaid.SelectedRows[0].Cells[1].Value.ToString()).First());
            RefreshPay();
        }

        private void buttonBioPago_Click(object sender, EventArgs e)
        {
            Input input = new Input("Pagar con BioPago", Total - Pagado);
            input.ShowDialog();
            if (input.DialogResult == DialogResult.OK)
            {
                Database.TemporaryData.PayTemps.Add(new Database.PayTemp
                {
                    PayMethod = "BioPago",
                    Amount = input.Cantidad
                });
            }
            RefreshPay();
        }

        private void buttonCredito_Click(object sender, EventArgs e)
        {
            Input input = new Input("Pagar con Crédito", (Total - Pagado));
            input.ShowDialog();
            if (input.DialogResult == DialogResult.OK)
            {
                Database.TemporaryData.PayTemps.Add(new Database.PayTemp
                {
                    PayMethod = "Credito",
                    Amount = input.Cantidad
                });
            }
            RefreshPay();
        }

        private void buttonDolares_Click(object sender, EventArgs e)
        {
            int dolares = ((int)((Total - Pagado) / Database.TasaDolar.Tasa));
            Input input = new Input("Pagar con Dólares", dolares);
            input.ShowDialog();
            if (input.DialogResult == DialogResult.OK)
            {
                Database.TemporaryData.PayTemps.Add(new Database.PayTemp
                {
                    PayMethod = "Dolares",
                    Amount = input.Cantidad * Database.TasaDolar.Tasa
                });
            }
            RefreshPay();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void buttonFacturar_Click(object sender, EventArgs e)
        {
            if (Database.TemporaryData.CarritoLista.Count == 0)
            {
                new Mensaje("Carrito vacio", "El carrito de compras está vacio para poder facturar").ShowDialog();
                return;
            }
            if (Pagado < Total)
            {
                new Mensaje("Monto incompleto", "Se debe pagar el monto completo para poder facturar").ShowDialog();
                return;
            }

            InputClient inputClient = new InputClient();
            inputClient.ShowDialog();

            if (inputClient.DialogResult == DialogResult.OK)
            {
                if (Print.Informacion.NombreEmpresa == "" || Print.Informacion.RIF == "" || Print.Informacion.Telefono == "" || Print.Informacion.Direccion == "")
                {
                    new Mensaje("Error información", "Debe rellenar la información de la empresa").ShowDialog();
                    return;
                }

                Print.GuardarCompra();
                Print.PrintPDF(inputClient.Nombre, inputClient.CI, inputClient.Tlf);

                foreach (Database.ProductTemp productTemp in Database.TemporaryData.CarritoLista)
                {
                    if (!Database.TemporaryData.MasVendidos.Any(x => x.ID == productTemp.Codigo))
                    {
                        Database.TemporaryData.MasVendidos.Add(new Database.ProductosComprados
                        {
                            ID = productTemp.Codigo,
                            ProductName = "",
                            Selled = 0
                        });
                    }
                    Database.TemporaryData.MasVendidos.Where(x => x.ID == productTemp.Codigo).First().ProductName = productTemp.ProductoNombre;
                    Database.TemporaryData.MasVendidos.Where(x => x.ID == productTemp.Codigo).First().Selled += productTemp.Cantidad;
                }
                Database.TemporaryData.SaveComprados();

                Database.TemporaryData.CarritoLista.Clear();
                Database.TemporaryData.PayTemps.Clear();

                Program.MainFormInteract.PutInContainer(new Facturacion());
                this.Close();
            }
        }
    }
}
