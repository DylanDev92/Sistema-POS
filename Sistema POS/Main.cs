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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CustomDesign();
        }

        private void panelMenuLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomDesign()
        {
            panelFacturacion.Visible = false;
            panelVentas.Visible = false;
            panelConfiguracion.Visible = false;
            panelProductos.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelFacturacion.Visible == true)
            {
                panelFacturacion.Visible = false;
            }
            if (panelVentas.Visible == true)
            {
                panelVentas.Visible = false;
            } 
            if (panelProductos.Visible == true)
            {
                panelProductos.Visible = false;
            }
            if (panelConfiguracion.Visible == true)
            {
                panelConfiguracion.Visible = false;
            }
        }

        private void ShowPanel(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
        }

        private void buttonFacturacion_Click(object sender, EventArgs e)
        {
            ShowPanel(panelFacturacion);
            PutInContainer(new Facturacion());
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            ShowPanel(panelVentas);
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            ShowPanel(panelProductos);
            PutInContainer(new Productos());
        }

        private void buttonConfiguracion_Click(object sender, EventArgs e)
        {
            
        }

        private Form activeForm { get; set; }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Database.TasaDolar.LabelTasa = labelTasa;

            labelTasa.Text = "Tasa: " + Database.TasaDolar.Tasa.ToString("N2");

            label1.Text = Print.Informacion.NombreEmpresa;

            ShowPanel(panelFacturacion);

            PutInContainer(new Facturacion());
        }

        public void PutInContainer(Form childForm)
        {
            if (activeForm != null)
            {
                if (activeForm.Name == childForm.Name) return;

                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void buttonTasa_Click(object sender, EventArgs e)
        {
            ShowPanel(panelProductos);

            PutInContainer(new TasaDolar());
        }

        private void buttonConsultaProducto_Click(object sender, EventArgs e)
        {
            ShowPanel(panelProductos);

            PutInContainer(new ConsultaProductos());
        }

        private void buttonConfiguracion_Click_1(object sender, EventArgs e)
        {
            ShowPanel(panelConfiguracion);
        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            HideSubMenu();

            PutInContainer(new ConsultaProductos());
        }

        private void buttonCobrar_Click(object sender, EventArgs e)
        {
            ShowPanel(panelFacturacion);

            PutInContainer(new Pagar());
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Hello");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    ShowPanel(panelFacturacion);
                    PutInContainer(new Facturacion());
                    break;
                case Keys.F2:
                    ShowPanel(panelFacturacion);
                    PutInContainer(new Pagar());
                    break;
                case Keys.F3:
                    IrOEspera();
                    break;
                case Keys.F4:
                    HideSubMenu();
                    PutInContainer(new ConsultaProductos());
                    break;
                default:
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonEnEspera_Click(object sender, EventArgs e)
        {
            IrOEspera();
        }

        public void IrOEspera()
        {
            if (Database.TemporaryData.CarritoLista.Count > 0)
            {
                Desicion desicion = new Desicion("Guardar lista", "Podrá recuperar la lista y borrarla posteriormente");
                desicion.ShowDialog();
                if (desicion.DialogResult == DialogResult.OK)
                {
                    string cliente = "No asignado";

                    Input input = new Input("Nombre/ID de cliente", 0, true);
                    input.ShowDialog();
                    if (input.DialogResult == DialogResult.OK)
                    {
                        cliente = input.StringGet;
                    }

                    Database.TemporaryData.SaveEspera(cliente);

                    ShowPanel(panelFacturacion);
                    PutInContainer(new Facturacion());
                }
            }
            else
            {
                ShowPanel(panelFacturacion);
                PutInContainer(new ListaEspera());
            }
        }

        private void buttonInformacion_Click(object sender, EventArgs e)
        {
            ShowPanel(panelConfiguracion);

            PutInContainer(new Informacion());
        }

        private void buttonMasVendidos_Click(object sender, EventArgs e)
        {
            ShowPanel(panelProductos);

            PutInContainer(new MasVendidos());
        }
    }
}
