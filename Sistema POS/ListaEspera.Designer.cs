namespace Sistema_POS
{
    partial class ListaEspera
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
            this.panelRIght = new System.Windows.Forms.Panel();
            this.dataGridViewListaSave = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewProductList = new System.Windows.Forms.DataGridView();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotalProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonTop = new System.Windows.Forms.Button();
            this.buttonArriba = new System.Windows.Forms.Button();
            this.buttonAbajo = new System.Windows.Forms.Button();
            this.buttonBottom = new System.Windows.Forms.Button();
            this.tableLayoutPanelPayAmount = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.panelRIght.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaSave)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).BeginInit();
            this.tableLayoutPanelPayAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRIght
            // 
            this.panelRIght.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRIght.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.panelRIght.Controls.Add(this.dataGridViewListaSave);
            this.panelRIght.Location = new System.Drawing.Point(0, 0);
            this.panelRIght.Name = "panelRIght";
            this.panelRIght.Padding = new System.Windows.Forms.Padding(10);
            this.panelRIght.Size = new System.Drawing.Size(361, 436);
            this.panelRIght.TabIndex = 2;
            // 
            // dataGridViewListaSave
            // 
            this.dataGridViewListaSave.AllowUserToAddRows = false;
            this.dataGridViewListaSave.AllowUserToDeleteRows = false;
            this.dataGridViewListaSave.AllowUserToResizeRows = false;
            this.dataGridViewListaSave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaSave.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewListaSave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListaSave.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewListaSave.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListaSave.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewListaSave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaSave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DateTime,
            this.Cliente,
            this.PrecioTotal});
            this.dataGridViewListaSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListaSave.EnableHeadersVisualStyles = false;
            this.dataGridViewListaSave.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridViewListaSave.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewListaSave.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewListaSave.MultiSelect = false;
            this.dataGridViewListaSave.Name = "dataGridViewListaSave";
            this.dataGridViewListaSave.ReadOnly = true;
            this.dataGridViewListaSave.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewListaSave.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewListaSave.RowTemplate.Height = 30;
            this.dataGridViewListaSave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewListaSave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaSave.Size = new System.Drawing.Size(341, 416);
            this.dataGridViewListaSave.TabIndex = 3;
            this.dataGridViewListaSave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListaSave_CellContentClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 27.55398F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // DateTime
            // 
            this.DateTime.FillWeight = 117.1024F;
            this.DateTime.HeaderText = "Fecha";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.FillWeight = 67.45295F;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.FillWeight = 117.4502F;
            this.PrecioTotal.HeaderText = "Precio total";
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.dataGridViewProductList);
            this.panel1.Location = new System.Drawing.Point(356, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(364, 191);
            this.panel1.TabIndex = 4;
            // 
            // dataGridViewProductList
            // 
            this.dataGridViewProductList.AllowUserToAddRows = false;
            this.dataGridViewProductList.AllowUserToDeleteRows = false;
            this.dataGridViewProductList.AllowUserToResizeRows = false;
            this.dataGridViewProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProductList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto,
            this.CantidadProducto,
            this.DescripcionProducto,
            this.PrecioTotalProducto});
            this.dataGridViewProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProductList.EnableHeadersVisualStyles = false;
            this.dataGridViewProductList.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridViewProductList.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewProductList.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProductList.MultiSelect = false;
            this.dataGridViewProductList.Name = "dataGridViewProductList";
            this.dataGridViewProductList.ReadOnly = true;
            this.dataGridViewProductList.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewProductList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewProductList.RowTemplate.Height = 25;
            this.dataGridViewProductList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductList.Size = new System.Drawing.Size(344, 171);
            this.dataGridViewProductList.TabIndex = 3;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.FillWeight = 58.46878F;
            this.CodigoProducto.HeaderText = "Codigo";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            // 
            // CantidadProducto
            // 
            this.CantidadProducto.FillWeight = 75.2801F;
            this.CantidadProducto.HeaderText = "Cantidad";
            this.CantidadProducto.Name = "CantidadProducto";
            this.CantidadProducto.ReadOnly = true;
            // 
            // DescripcionProducto
            // 
            this.DescripcionProducto.FillWeight = 102.7859F;
            this.DescripcionProducto.HeaderText = "Descripcion";
            this.DescripcionProducto.Name = "DescripcionProducto";
            this.DescripcionProducto.ReadOnly = true;
            // 
            // PrecioTotalProducto
            // 
            this.PrecioTotalProducto.FillWeight = 93.02474F;
            this.PrecioTotalProducto.HeaderText = "Precio total";
            this.PrecioTotalProducto.Name = "PrecioTotalProducto";
            this.PrecioTotalProducto.ReadOnly = true;
            // 
            // buttonTop
            // 
            this.buttonTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.buttonTop.FlatAppearance.BorderSize = 0;
            this.buttonTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTop.ForeColor = System.Drawing.Color.White;
            this.buttonTop.Location = new System.Drawing.Point(367, 202);
            this.buttonTop.Name = "buttonTop";
            this.buttonTop.Size = new System.Drawing.Size(50, 50);
            this.buttonTop.TabIndex = 5;
            this.buttonTop.Text = "↑↑↑";
            this.buttonTop.UseVisualStyleBackColor = false;
            this.buttonTop.Click += new System.EventHandler(this.buttonTop_Click);
            // 
            // buttonArriba
            // 
            this.buttonArriba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.buttonArriba.FlatAppearance.BorderSize = 0;
            this.buttonArriba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArriba.ForeColor = System.Drawing.Color.White;
            this.buttonArriba.Location = new System.Drawing.Point(367, 258);
            this.buttonArriba.Name = "buttonArriba";
            this.buttonArriba.Size = new System.Drawing.Size(50, 50);
            this.buttonArriba.TabIndex = 6;
            this.buttonArriba.Text = "↑";
            this.buttonArriba.UseVisualStyleBackColor = false;
            this.buttonArriba.Click += new System.EventHandler(this.buttonArriba_Click);
            // 
            // buttonAbajo
            // 
            this.buttonAbajo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.buttonAbajo.FlatAppearance.BorderSize = 0;
            this.buttonAbajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbajo.ForeColor = System.Drawing.Color.White;
            this.buttonAbajo.Location = new System.Drawing.Point(367, 314);
            this.buttonAbajo.Name = "buttonAbajo";
            this.buttonAbajo.Size = new System.Drawing.Size(50, 50);
            this.buttonAbajo.TabIndex = 7;
            this.buttonAbajo.Text = "↓";
            this.buttonAbajo.UseVisualStyleBackColor = false;
            this.buttonAbajo.Click += new System.EventHandler(this.buttonAbajo_Click);
            // 
            // buttonBottom
            // 
            this.buttonBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.buttonBottom.FlatAppearance.BorderSize = 0;
            this.buttonBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBottom.ForeColor = System.Drawing.Color.White;
            this.buttonBottom.Location = new System.Drawing.Point(367, 370);
            this.buttonBottom.Name = "buttonBottom";
            this.buttonBottom.Size = new System.Drawing.Size(50, 50);
            this.buttonBottom.TabIndex = 8;
            this.buttonBottom.Text = "↓↓↓";
            this.buttonBottom.UseVisualStyleBackColor = false;
            this.buttonBottom.Click += new System.EventHandler(this.buttonBottom_Click);
            // 
            // tableLayoutPanelPayAmount
            // 
            this.tableLayoutPanelPayAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelPayAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.tableLayoutPanelPayAmount.ColumnCount = 2;
            this.tableLayoutPanelPayAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.93458F));
            this.tableLayoutPanelPayAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.06542F));
            this.tableLayoutPanelPayAmount.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanelPayAmount.Controls.Add(this.labelTotal, 0, 0);
            this.tableLayoutPanelPayAmount.Controls.Add(this.textBoxCliente, 1, 0);
            this.tableLayoutPanelPayAmount.Controls.Add(this.textBoxTotal, 1, 1);
            this.tableLayoutPanelPayAmount.Location = new System.Drawing.Point(431, 202);
            this.tableLayoutPanelPayAmount.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelPayAmount.Name = "tableLayoutPanelPayAmount";
            this.tableLayoutPanelPayAmount.RowCount = 2;
            this.tableLayoutPanelPayAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.73585F));
            this.tableLayoutPanelPayAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.26415F));
            this.tableLayoutPanelPayAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPayAmount.Size = new System.Drawing.Size(279, 106);
            this.tableLayoutPanelPayAmount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTotal.Location = new System.Drawing.Point(3, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(66, 40);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Cliente:";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCliente.BackColor = System.Drawing.Color.White;
            this.textBoxCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCliente.Location = new System.Drawing.Point(72, 10);
            this.textBoxCliente.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(197, 20);
            this.textBoxCliente.TabIndex = 11;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotal.BackColor = System.Drawing.Color.White;
            this.textBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotal.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(72, 51);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(197, 43);
            this.textBoxTotal.TabIndex = 12;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(431, 337);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(120, 65);
            this.buttonEliminar.TabIndex = 9;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonCargar
            // 
            this.buttonCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.buttonCargar.FlatAppearance.BorderSize = 0;
            this.buttonCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCargar.ForeColor = System.Drawing.Color.White;
            this.buttonCargar.Location = new System.Drawing.Point(590, 337);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(120, 65);
            this.buttonCargar.TabIndex = 10;
            this.buttonCargar.Text = "Abrir y facturar";
            this.buttonCargar.UseVisualStyleBackColor = false;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // ListaEspera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(718, 433);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.tableLayoutPanelPayAmount);
            this.Controls.Add(this.buttonBottom);
            this.Controls.Add(this.buttonAbajo);
            this.Controls.Add(this.buttonArriba);
            this.Controls.Add(this.buttonTop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRIght);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListaEspera";
            this.Text = "ListaEspera";
            this.Load += new System.EventHandler(this.ListaEspera_Load);
            this.panelRIght.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaSave)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).EndInit();
            this.tableLayoutPanelPayAmount.ResumeLayout(false);
            this.tableLayoutPanelPayAmount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRIght;
        private System.Windows.Forms.DataGridView dataGridViewListaSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewProductList;
        private System.Windows.Forms.Button buttonTop;
        private System.Windows.Forms.Button buttonArriba;
        private System.Windows.Forms.Button buttonAbajo;
        private System.Windows.Forms.Button buttonBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPayAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotalProducto;
    }
}