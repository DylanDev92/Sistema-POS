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
    public partial class Input : Form
    {
        private float PreInput { get; set; }
        private bool IsString { get; set; }
        public Input(string MensajeBreve, float preInput = 0, bool isString = false)
        {
            InitializeComponent();

            labelTextoBreve.Text = MensajeBreve;

            PreInput = preInput;

            IsString = isString;
        }
        public string StringGet { get; set; }
        public float Cantidad { get; set; }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void Input_Shown(object sender, EventArgs e)
        {
            textBoxInput.Focus();

            if (PreInput > 0)
            {
                textBoxInput.Text = PreInput.ToString("N2");
                textBoxInput.SelectAll();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsString == false)
            {
                DialogResult = DialogResult.OK;

                if (string.IsNullOrEmpty(textBoxInput.Text) || float.Parse(textBoxInput.Text) == 0.00f)
                {
                    Cantidad = 0;
                }
                else
                {
                    Cantidad = float.Parse(textBoxInput.Text);
                }

                this.Close();
            }
            else
            {
                DialogResult = DialogResult.OK;

                StringGet = textBoxInput.Text;

                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsString == false)
            {
                if (Fun.CheckCommaInTextbox(e, textBoxInput)) return;

                if (e.KeyChar != (char)Keys.Enter) return;

                DialogResult = DialogResult.OK;

                if (string.IsNullOrEmpty(textBoxInput.Text) || float.Parse(textBoxInput.Text) == 0.00f)
                {
                    Cantidad = 0;
                }
                else
                {
                    Cantidad = float.Parse(textBoxInput.Text);
                }
                this.Close();
            }
            else
            {
                if (e.KeyChar != (char)Keys.Enter) return;

                DialogResult = DialogResult.OK;

                StringGet = textBoxInput.Text;

                this.Close();
            }
        }

        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            //e.Handled = true;
            //e.SuppressKeyPress = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
