namespace Sistema_POS
{
    partial class Pagar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRIght = new System.Windows.Forms.Panel();
            this.tableLayoutPanelPayAmount = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxRestante = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelMetodos = new System.Windows.Forms.Panel();
            this.dataGridViewPaid = new System.Windows.Forms.DataGridView();
            this.PayMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDolares = new System.Windows.Forms.Button();
            this.buttonCredito = new System.Windows.Forms.Button();
            this.buttonBioPago = new System.Windows.Forms.Button();
            this.buttonDebit = new System.Windows.Forms.Button();
            this.buttonFacturar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.panelRIght.SuspendLayout();
            this.tableLayoutPanelPayAmount.SuspendLayout();
            this.panelMetodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaid)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridViewProductos.ColumnHeadersVisible = false;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.PrecioTotal});
            this.dataGridViewProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProductos.EnableHeadersVisualStyles = false;
            this.dataGridViewProductos.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridViewProductos.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewProductos.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProductos.MultiSelect = false;
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProductos.RowTemplate.Height = 20;
            this.dataGridViewProductos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.Size = new System.Drawing.Size(253, 413);
            this.dataGridViewProductos.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.FillWeight = 66.34668F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 116.5277F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.FillWeight = 46.68518F;
            this.PrecioTotal.HeaderText = "Precio total";
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.ReadOnly = true;
            // 
            // panelRIght
            // 
            this.panelRIght.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRIght.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.panelRIght.Controls.Add(this.dataGridViewProductos);
            this.panelRIght.Location = new System.Drawing.Point(447, 0);
            this.panelRIght.Name = "panelRIght";
            this.panelRIght.Padding = new System.Windows.Forms.Padding(10);
            this.panelRIght.Size = new System.Drawing.Size(273, 433);
            this.panelRIght.TabIndex = 1;
            // 
            // tableLayoutPanelPayAmount
            // 
            this.tableLayoutPanelPayAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelPayAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.tableLayoutPanelPayAmount.ColumnCount = 2;
            this.tableLayoutPanelPayAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.93458F));
            this.tableLayoutPanelPayAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.06542F));
            this.tableLayoutPanelPayAmount.Controls.Add(this.textBoxRestante, 1, 1);
            this.tableLayoutPanelPayAmount.Controls.Add(this.textBoxTotal, 1, 0);
            this.tableLayoutPanelPayAmount.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelPayAmount.Controls.Add(this.labelTotal, 0, 0);
            this.tableLayoutPanelPayAmount.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanelPayAmount.Name = "tableLayoutPanelPayAmount";
            this.tableLayoutPanelPayAmount.RowCount = 2;
            this.tableLayoutPanelPayAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPayAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPayAmount.Size = new System.Drawing.Size(428, 151);
            this.tableLayoutPanelPayAmount.TabIndex = 2;
            // 
            // textBoxRestante
            // 
            this.textBoxRestante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRestante.BackColor = System.Drawing.Color.White;
            this.textBoxRestante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRestante.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRestante.Location = new System.Drawing.Point(111, 90);
            this.textBoxRestante.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.textBoxRestante.Name = "textBoxRestante";
            this.textBoxRestante.ReadOnly = true;
            this.textBoxRestante.Size = new System.Drawing.Size(307, 46);
            this.textBoxRestante.TabIndex = 11;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotal.BackColor = System.Drawing.Color.White;
            this.textBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotal.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(111, 14);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(307, 46);
            this.textBoxTotal.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 76);
            this.label2.TabIndex = 2;
            this.label2.Text = "RESTANTE:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotal.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTotal.Location = new System.Drawing.Point(3, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(105, 75);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "TOTAL:";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelMetodos
            // 
            this.panelMetodos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMetodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.panelMetodos.Controls.Add(this.dataGridViewPaid);
            this.panelMetodos.Controls.Add(this.buttonDolares);
            this.panelMetodos.Controls.Add(this.buttonCredito);
            this.panelMetodos.Controls.Add(this.buttonBioPago);
            this.panelMetodos.Controls.Add(this.buttonDebit);
            this.panelMetodos.Location = new System.Drawing.Point(-7, 172);
            this.panelMetodos.Margin = new System.Windows.Forms.Padding(10);
            this.panelMetodos.Name = "panelMetodos";
            this.panelMetodos.Size = new System.Drawing.Size(454, 132);
            this.panelMetodos.TabIndex = 3;
            // 
            // dataGridViewPaid
            // 
            this.dataGridViewPaid.AllowUserToAddRows = false;
            this.dataGridViewPaid.AllowUserToDeleteRows = false;
            this.dataGridViewPaid.AllowUserToResizeRows = false;
            this.dataGridViewPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPaid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPaid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.dataGridViewPaid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPaid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewPaid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPaid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PayMethod,
            this.Amount});
            this.dataGridViewPaid.EnableHeadersVisualStyles = false;
            this.dataGridViewPaid.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridViewPaid.Location = new System.Drawing.Point(235, 13);
            this.dataGridViewPaid.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewPaid.MultiSelect = false;
            this.dataGridViewPaid.Name = "dataGridViewPaid";
            this.dataGridViewPaid.ReadOnly = true;
            this.dataGridViewPaid.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewPaid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPaid.RowTemplate.Height = 20;
            this.dataGridViewPaid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewPaid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPaid.Size = new System.Drawing.Size(208, 106);
            this.dataGridViewPaid.TabIndex = 4;
            this.dataGridViewPaid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPaid_CellDoubleClick);
            // 
            // PayMethod
            // 
            this.PayMethod.FillWeight = 60.9137F;
            this.PayMethod.HeaderText = "Pago";
            this.PayMethod.Name = "PayMethod";
            this.PayMethod.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.FillWeight = 139.0863F;
            this.Amount.HeaderText = "Bolívares";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // buttonDolares
            // 
            this.buttonDolares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.buttonDolares.FlatAppearance.BorderSize = 0;
            this.buttonDolares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDolares.ForeColor = System.Drawing.Color.White;
            this.buttonDolares.Location = new System.Drawing.Point(121, 69);
            this.buttonDolares.Name = "buttonDolares";
            this.buttonDolares.Size = new System.Drawing.Size(100, 50);
            this.buttonDolares.TabIndex = 3;
            this.buttonDolares.Text = "Dolares";
            this.buttonDolares.UseVisualStyleBackColor = false;
            this.buttonDolares.Click += new System.EventHandler(this.buttonDolares_Click);
            // 
            // buttonCredito
            // 
            this.buttonCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.buttonCredito.FlatAppearance.BorderSize = 0;
            this.buttonCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCredito.ForeColor = System.Drawing.Color.White;
            this.buttonCredito.Location = new System.Drawing.Point(15, 69);
            this.buttonCredito.Name = "buttonCredito";
            this.buttonCredito.Size = new System.Drawing.Size(100, 50);
            this.buttonCredito.TabIndex = 2;
            this.buttonCredito.Text = "Credito";
            this.buttonCredito.UseVisualStyleBackColor = false;
            this.buttonCredito.Click += new System.EventHandler(this.buttonCredito_Click);
            // 
            // buttonBioPago
            // 
            this.buttonBioPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.buttonBioPago.FlatAppearance.BorderSize = 0;
            this.buttonBioPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBioPago.ForeColor = System.Drawing.Color.White;
            this.buttonBioPago.Location = new System.Drawing.Point(121, 13);
            this.buttonBioPago.Name = "buttonBioPago";
            this.buttonBioPago.Size = new System.Drawing.Size(100, 50);
            this.buttonBioPago.TabIndex = 1;
            this.buttonBioPago.Text = "BioPago";
            this.buttonBioPago.UseVisualStyleBackColor = false;
            this.buttonBioPago.Click += new System.EventHandler(this.buttonBioPago_Click);
            // 
            // buttonDebit
            // 
            this.buttonDebit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.buttonDebit.FlatAppearance.BorderSize = 0;
            this.buttonDebit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDebit.ForeColor = System.Drawing.Color.White;
            this.buttonDebit.Location = new System.Drawing.Point(15, 13);
            this.buttonDebit.Name = "buttonDebit";
            this.buttonDebit.Size = new System.Drawing.Size(100, 50);
            this.buttonDebit.TabIndex = 0;
            this.buttonDebit.Text = "Debito";
            this.buttonDebit.UseVisualStyleBackColor = false;
            this.buttonDebit.Click += new System.EventHandler(this.buttonDebit_Click);
            // 
            // buttonFacturar
            // 
            this.buttonFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.buttonFacturar.FlatAppearance.BorderSize = 0;
            this.buttonFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFacturar.ForeColor = System.Drawing.Color.White;
            this.buttonFacturar.Location = new System.Drawing.Point(8, 317);
            this.buttonFacturar.Name = "buttonFacturar";
            this.buttonFacturar.Size = new System.Drawing.Size(130, 70);
            this.buttonFacturar.TabIndex = 4;
            this.buttonFacturar.Text = "Facturar y Guardar";
            this.buttonFacturar.UseVisualStyleBackColor = false;
            this.buttonFacturar.Click += new System.EventHandler(this.buttonFacturar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(144, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 70);
            this.button2.TabIndex = 5;
            this.button2.Text = "Facturar, Guardar y Enviar al cliente";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(306, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 70);
            this.button3.TabIndex = 6;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(718, 433);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonFacturar);
            this.Controls.Add(this.panelMetodos);
            this.Controls.Add(this.tableLayoutPanelPayAmount);
            this.Controls.Add(this.panelRIght);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pagar";
            this.Text = "Pagar";
            this.Load += new System.EventHandler(this.Pagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.panelRIght.ResumeLayout(false);
            this.tableLayoutPanelPayAmount.ResumeLayout(false);
            this.tableLayoutPanelPayAmount.PerformLayout();
            this.panelMetodos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Panel panelRIght;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPayAmount;
        private System.Windows.Forms.TextBox textBoxRestante;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Panel panelMetodos;
        private System.Windows.Forms.Button buttonDolares;
        private System.Windows.Forms.Button buttonCredito;
        private System.Windows.Forms.Button buttonBioPago;
        private System.Windows.Forms.Button buttonDebit;
        private System.Windows.Forms.Button buttonFacturar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
        private System.Windows.Forms.DataGridView dataGridViewPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}