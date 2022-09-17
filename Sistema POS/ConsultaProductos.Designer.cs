namespace Sistema_POS
{
    partial class ConsultaProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSeparator3 = new System.Windows.Forms.Panel();
            this.textBoxInputCode = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelDolares = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelIVA = new System.Windows.Forms.Label();
            this.labelExento = new System.Windows.Forms.Label();
            this.labelBaseImponible = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelNameProduct = new System.Windows.Forms.Label();
            this.labelCodigoProducto = new System.Windows.Forms.Label();
            this.panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.panelSideBar.Controls.Add(this.dataGridViewProductos);
            this.panelSideBar.Controls.Add(this.panel1);
            this.panelSideBar.Controls.Add(this.panelSeparator3);
            this.panelSideBar.Controls.Add(this.textBoxInputCode);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Padding = new System.Windows.Forms.Padding(17, 22, 17, 0);
            this.panelSideBar.Size = new System.Drawing.Size(380, 433);
            this.panelSideBar.TabIndex = 2;
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.AllowUserToResizeRows = false;
            this.dataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Precio});
            this.dataGridViewProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProductos.EnableHeadersVisualStyles = false;
            this.dataGridViewProductos.Location = new System.Drawing.Point(17, 75);
            this.dataGridViewProductos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridViewProductos.MultiSelect = false;
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowHeadersVisible = false;
            this.dataGridViewProductos.RowTemplate.Height = 30;
            this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.Size = new System.Drawing.Size(346, 337);
            this.dataGridViewProductos.TabIndex = 21;
            this.dataGridViewProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.FillWeight = 130.9067F;
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 50;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 155.5106F;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.FillWeight = 81.9916F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(17, 412);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 21);
            this.panel1.TabIndex = 20;
            // 
            // panelSeparator3
            // 
            this.panelSeparator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.panelSeparator3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeparator3.Location = new System.Drawing.Point(17, 55);
            this.panelSeparator3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelSeparator3.Name = "panelSeparator3";
            this.panelSeparator3.Size = new System.Drawing.Size(346, 20);
            this.panelSeparator3.TabIndex = 11;
            // 
            // textBoxInputCode
            // 
            this.textBoxInputCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInputCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxInputCode.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputCode.Location = new System.Drawing.Point(17, 22);
            this.textBoxInputCode.Margin = new System.Windows.Forms.Padding(17, 6, 17, 6);
            this.textBoxInputCode.Name = "textBoxInputCode";
            this.textBoxInputCode.Size = new System.Drawing.Size(346, 33);
            this.textBoxInputCode.TabIndex = 10;
            this.textBoxInputCode.TextChanged += new System.EventHandler(this.textBoxInputCode_TextChanged);
            this.textBoxInputCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInputCode_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(380, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(338, 433);
            this.panel2.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.panel4.Controls.Add(this.labelDolares);
            this.panel4.Controls.Add(this.labelTotal);
            this.panel4.Controls.Add(this.labelIVA);
            this.panel4.Controls.Add(this.labelExento);
            this.panel4.Controls.Add(this.labelBaseImponible);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(20, 120);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(20);
            this.panel4.Size = new System.Drawing.Size(298, 293);
            this.panel4.TabIndex = 1;
            // 
            // labelDolares
            // 
            this.labelDolares.AutoSize = true;
            this.labelDolares.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDolares.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDolares.ForeColor = System.Drawing.Color.White;
            this.labelDolares.Location = new System.Drawing.Point(20, 163);
            this.labelDolares.Name = "labelDolares";
            this.labelDolares.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelDolares.Size = new System.Drawing.Size(64, 24);
            this.labelDolares.TabIndex = 9;
            this.labelDolares.Text = "Dólares:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTotal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(20, 107);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.labelTotal.Size = new System.Drawing.Size(59, 56);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "Total:";
            // 
            // labelIVA
            // 
            this.labelIVA.AutoSize = true;
            this.labelIVA.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelIVA.ForeColor = System.Drawing.Color.White;
            this.labelIVA.Location = new System.Drawing.Point(20, 78);
            this.labelIVA.Name = "labelIVA";
            this.labelIVA.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.labelIVA.Size = new System.Drawing.Size(35, 29);
            this.labelIVA.TabIndex = 7;
            this.labelIVA.Text = "IVA:";
            // 
            // labelExento
            // 
            this.labelExento.AutoSize = true;
            this.labelExento.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelExento.ForeColor = System.Drawing.Color.White;
            this.labelExento.Location = new System.Drawing.Point(20, 49);
            this.labelExento.Name = "labelExento";
            this.labelExento.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.labelExento.Size = new System.Drawing.Size(60, 29);
            this.labelExento.TabIndex = 6;
            this.labelExento.Text = "Exento:";
            // 
            // labelBaseImponible
            // 
            this.labelBaseImponible.AutoSize = true;
            this.labelBaseImponible.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBaseImponible.ForeColor = System.Drawing.Color.White;
            this.labelBaseImponible.Location = new System.Drawing.Point(20, 20);
            this.labelBaseImponible.Name = "labelBaseImponible";
            this.labelBaseImponible.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.labelBaseImponible.Size = new System.Drawing.Size(44, 29);
            this.labelBaseImponible.TabIndex = 5;
            this.labelBaseImponible.Text = "Base:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.panel3.Controls.Add(this.labelNameProduct);
            this.panel3.Controls.Add(this.labelCodigoProducto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 20);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(298, 100);
            this.panel3.TabIndex = 0;
            // 
            // labelNameProduct
            // 
            this.labelNameProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNameProduct.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameProduct.ForeColor = System.Drawing.Color.White;
            this.labelNameProduct.Location = new System.Drawing.Point(10, 34);
            this.labelNameProduct.Name = "labelNameProduct";
            this.labelNameProduct.Size = new System.Drawing.Size(278, 56);
            this.labelNameProduct.TabIndex = 0;
            this.labelNameProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCodigoProducto
            // 
            this.labelCodigoProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCodigoProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoProducto.ForeColor = System.Drawing.Color.White;
            this.labelCodigoProducto.Location = new System.Drawing.Point(10, 10);
            this.labelCodigoProducto.Margin = new System.Windows.Forms.Padding(0);
            this.labelCodigoProducto.Name = "labelCodigoProducto";
            this.labelCodigoProducto.Size = new System.Drawing.Size(278, 24);
            this.labelCodigoProducto.TabIndex = 1;
            this.labelCodigoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConsultaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(718, 433);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSideBar);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultaProductos";
            this.Text = "ConsultaProductos";
            this.Load += new System.EventHandler(this.ConsultaProductos_Load);
            this.Shown += new System.EventHandler(this.ConsultaProductos_Shown);
            this.panelSideBar.ResumeLayout(false);
            this.panelSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Panel panelSeparator3;
        private System.Windows.Forms.TextBox textBoxInputCode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelNameProduct;
        private System.Windows.Forms.Label labelCodigoProducto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelDolares;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelIVA;
        private System.Windows.Forms.Label labelExento;
        private System.Windows.Forms.Label labelBaseImponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}