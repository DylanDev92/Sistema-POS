namespace Sistema_POS
{
    partial class MasVendidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelRIght = new System.Windows.Forms.Panel();
            this.dataGridViewListaSave = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descipcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.panelRIght.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaSave)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRIght
            // 
            this.panelRIght.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.panelRIght.Controls.Add(this.dataGridViewListaSave);
            this.panelRIght.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRIght.Location = new System.Drawing.Point(0, 0);
            this.panelRIght.Name = "panelRIght";
            this.panelRIght.Padding = new System.Windows.Forms.Padding(10);
            this.panelRIght.Size = new System.Drawing.Size(457, 433);
            this.panelRIght.TabIndex = 3;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListaSave.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewListaSave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaSave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descipcion,
            this.Cantidad});
            this.dataGridViewListaSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListaSave.EnableHeadersVisualStyles = false;
            this.dataGridViewListaSave.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridViewListaSave.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewListaSave.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewListaSave.MultiSelect = false;
            this.dataGridViewListaSave.Name = "dataGridViewListaSave";
            this.dataGridViewListaSave.ReadOnly = true;
            this.dataGridViewListaSave.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewListaSave.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewListaSave.RowTemplate.Height = 30;
            this.dataGridViewListaSave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewListaSave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaSave.Size = new System.Drawing.Size(437, 413);
            this.dataGridViewListaSave.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.FillWeight = 67.83359F;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descipcion
            // 
            this.Descipcion.FillWeight = 141.0534F;
            this.Descipcion.HeaderText = "Descripción";
            this.Descipcion.Name = "Descipcion";
            this.Descipcion.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.FillWeight = 53.21961F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.buttonReiniciar.FlatAppearance.BorderSize = 0;
            this.buttonReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReiniciar.ForeColor = System.Drawing.Color.White;
            this.buttonReiniciar.Location = new System.Drawing.Point(550, 353);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(156, 70);
            this.buttonReiniciar.TabIndex = 5;
            this.buttonReiniciar.Text = "Reiniciar más vendidos";
            this.buttonReiniciar.UseVisualStyleBackColor = false;
            // 
            // MasVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(718, 433);
            this.Controls.Add(this.buttonReiniciar);
            this.Controls.Add(this.panelRIght);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MasVendidos";
            this.Text = "MasVendidos";
            this.panelRIght.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRIght;
        private System.Windows.Forms.DataGridView dataGridViewListaSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descipcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button buttonReiniciar;
    }
}