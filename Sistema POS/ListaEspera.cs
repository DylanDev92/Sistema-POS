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
    public partial class ListaEspera : Form
    {
        public ListaEspera()
        {
            InitializeComponent();
        }

        private void ListaEspera_Load(object sender, EventArgs e)
        {
            dataGridViewListaSave.AutoGenerateColumns = false;

            dataGridViewListaSave.Columns["PrecioTotal"].DataPropertyName = "Amount";
            dataGridViewListaSave.Columns["ID"].DataPropertyName = "ID";
            dataGridViewListaSave.Columns["DateTime"].DataPropertyName = "DateTime";
            dataGridViewListaSave.Columns["Cliente"].DataPropertyName = "Client";
            dataGridViewListaSave.Columns["PrecioTotal"].DefaultCellStyle.Format = "N2";
            dataGridViewListaSave.Columns["DateTime"].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm";

            dataGridViewListaSave.DataSource = Database.TemporaryData.ListSave;

            dataGridViewProductList.AutoGenerateColumns = false;

            dataGridViewProductList.Columns["PrecioTotalProducto"].DataPropertyName = "PrecioTotal";
            dataGridViewProductList.Columns["DescripcionProducto"].DataPropertyName = "ProductoNombre";
            dataGridViewProductList.Columns["CantidadProducto"].DataPropertyName = "Cantidad";
            dataGridViewProductList.Columns["CodigoProducto"].DataPropertyName = "Codigo";
            dataGridViewProductList.Columns["PrecioTotalProducto"].DefaultCellStyle.Format = "N2";

            dataGridViewProductList.DataSource = ListaProductos;

            if (dataGridViewListaSave.Rows.Count > 0)
            {
                SelectedID = (int)dataGridViewListaSave.Rows[0].Cells[0].Value;
            }

            ActualizarInfo();
        }

        private int SelectedID { get; set; }

        private void buttonTop_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaSave.Rows.Count > 0)
            {
                Deselect();
                dataGridViewListaSave.Rows[0].Selected = true;
                SelectedID = (int)dataGridViewListaSave.Rows[0].Cells[0].Value;
                dataGridViewListaSave.FirstDisplayedScrollingRowIndex = dataGridViewListaSave.Rows[0].Index;
            }
            ActualizarInfo();
        }

        private void buttonBottom_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaSave.Rows.Count > 0)
            {
                Deselect();
                dataGridViewListaSave.Rows[dataGridViewListaSave.Rows.Count - 1].Selected = true;
                SelectedID = (int)dataGridViewListaSave.Rows[dataGridViewListaSave.Rows.Count - 1].Cells[0].Value;

                dataGridViewListaSave.FirstDisplayedScrollingRowIndex = dataGridViewListaSave.Rows[dataGridViewListaSave.Rows.Count - 1].Index;
            }
            ActualizarInfo();
        }

        private void Deselect()
        {
            foreach (DataGridViewRow row in dataGridViewListaSave.Rows)
            {
                row.Selected = false;
            }
        }

        private void buttonArriba_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaSave.Rows.Count > 0)
            {
                if (dataGridViewListaSave.SelectedRows[0].Index == 0) return;
                int index = dataGridViewListaSave.SelectedRows[0].Index - 1;
                Deselect();
                dataGridViewListaSave.Rows[index].Selected = true;
                SelectedID = (int)dataGridViewListaSave.SelectedRows[0].Cells[0].Value;
                dataGridViewListaSave.FirstDisplayedScrollingRowIndex = dataGridViewListaSave.SelectedRows[0].Index;
            }
            ActualizarInfo();
        }

        private void buttonAbajo_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaSave.Rows.Count > 0)
            {
                if (dataGridViewListaSave.SelectedRows[0].Index == dataGridViewListaSave.Rows.Count - 1) return;
                int index = dataGridViewListaSave.SelectedRows[0].Index + 1;
                Deselect();
                dataGridViewListaSave.Rows[index].Selected = true;
                SelectedID = (int)dataGridViewListaSave.SelectedRows[0].Cells[0].Value;
                dataGridViewListaSave.FirstDisplayedScrollingRowIndex = dataGridViewListaSave.SelectedRows[0].Index;
            }
            ActualizarInfo();
        }

        private void dataGridViewListaSave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedID = (int)dataGridViewListaSave.SelectedRows[0].Cells[0].Value;
            ActualizarInfo();
        }

        private BindingList<Database.ProductTemp> ListaProductos { get; set; } = new BindingList<Database.ProductTemp>();

        private void ActualizarInfo()
        {
            try
            {
                foreach (Database.ListProductSave listProduct in Database.TemporaryData.ListSave.Where(x => x.ID == 0))
                {
                    Database.TemporaryData.ListSave.Remove(listProduct);
                }
            }
            catch { }
            

            foreach (Database.ListProductSave producto in Database.TemporaryData.ListSave.Where(x => x.ID == SelectedID))
            {
                dataGridViewProductList.DataSource = producto.ListaProductos;

                textBoxCliente.Text = producto.Client;
                textBoxTotal.Text = producto.Amount.ToString("N2");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Desicion desicion = new Desicion("Eliminar de lista", "No se podrá recuperar la lista una vez borrada");
            desicion.ShowDialog();

            if (desicion.DialogResult == DialogResult.OK)
            {
                Database.TemporaryData.DeleteEspera(SelectedID);
                if (dataGridViewListaSave.Rows.Count == 0)
                {
                    dataGridViewListaSave.DataSource = null;
                    textBoxCliente.Text = "";
                    textBoxTotal.Text = "";
                    return;
                }
                SelectedID = (int)dataGridViewListaSave.SelectedRows[0].Cells[0].Value;
                ActualizarInfo();
            }
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            foreach (Database.ListProductSave producto in Database.TemporaryData.ListSave.Where(x => x.ID == SelectedID))
            {
                BindingList<Database.ProductTemp> carritoLista = new BindingList<Database.ProductTemp>();

                foreach (Database.ProductTemp productTemp in producto.ListaProductos)
                {
                    carritoLista.Add(productTemp);
                }

                Database.TemporaryData.CarritoLista = carritoLista;
                Database.TemporaryData.DeleteEspera(SelectedID);
                Program.MainFormInteract.PutInContainer(new Facturacion());
                producto.ID = 0;
                this.Close();
                return;
            }
        }
    }
}
