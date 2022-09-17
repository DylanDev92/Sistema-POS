namespace Sistema_POS
{
    partial class TasaDolar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasaDolar));
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.dataGridViewDolares = new System.Windows.Forms.DataGridView();
            this.Multiplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSeparator3 = new System.Windows.Forms.Panel();
            this.textBoxInputTasa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDol = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxDolar = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxBolivar = new System.Windows.Forms.TextBox();
            this.labelBol = new System.Windows.Forms.Label();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDolares)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.panelSideBar.Controls.Add(this.dataGridViewDolares);
            this.panelSideBar.Controls.Add(this.panelSeparator3);
            this.panelSideBar.Controls.Add(this.textBoxInputTasa);
            this.panelSideBar.Controls.Add(this.label1);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Padding = new System.Windows.Forms.Padding(23, 32, 23, 23);
            this.panelSideBar.Size = new System.Drawing.Size(327, 433);
            this.panelSideBar.TabIndex = 2;
            // 
            // dataGridViewDolares
            // 
            this.dataGridViewDolares.AllowUserToAddRows = false;
            this.dataGridViewDolares.AllowUserToDeleteRows = false;
            this.dataGridViewDolares.AllowUserToResizeRows = false;
            this.dataGridViewDolares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDolares.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridViewDolares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDolares.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewDolares.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDolares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDolares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDolares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Multiplicacion,
            this.Total});
            this.dataGridViewDolares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDolares.EnableHeadersVisualStyles = false;
            this.dataGridViewDolares.Location = new System.Drawing.Point(23, 120);
            this.dataGridViewDolares.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridViewDolares.Name = "dataGridViewDolares";
            this.dataGridViewDolares.RowHeadersVisible = false;
            this.dataGridViewDolares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDolares.Size = new System.Drawing.Size(281, 290);
            this.dataGridViewDolares.TabIndex = 13;
            // 
            // Multiplicacion
            // 
            this.Multiplicacion.FillWeight = 35.76924F;
            this.Multiplicacion.HeaderText = "X";
            this.Multiplicacion.Name = "Multiplicacion";
            this.Multiplicacion.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.FillWeight = 140.3943F;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // panelSeparator3
            // 
            this.panelSeparator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.panelSeparator3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeparator3.Location = new System.Drawing.Point(23, 100);
            this.panelSeparator3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelSeparator3.Name = "panelSeparator3";
            this.panelSeparator3.Size = new System.Drawing.Size(281, 20);
            this.panelSeparator3.TabIndex = 12;
            // 
            // textBoxInputTasa
            // 
            this.textBoxInputTasa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInputTasa.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxInputTasa.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputTasa.Location = new System.Drawing.Point(23, 70);
            this.textBoxInputTasa.Margin = new System.Windows.Forms.Padding(17, 6, 17, 6);
            this.textBoxInputTasa.Name = "textBoxInputTasa";
            this.textBoxInputTasa.Size = new System.Drawing.Size(281, 30);
            this.textBoxInputTasa.TabIndex = 11;
            this.textBoxInputTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxInputTasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInputTasa_KeyPress);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "TASA DÓLAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDol
            // 
            this.labelDol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.labelDol.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDol.ForeColor = System.Drawing.Color.White;
            this.labelDol.Location = new System.Drawing.Point(339, 136);
            this.labelDol.Name = "labelDol";
            this.labelDol.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelDol.Size = new System.Drawing.Size(369, 44);
            this.labelDol.TabIndex = 14;
            this.labelDol.Text = "DÓLAR";
            this.labelDol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.textBoxDolar);
            this.panel2.Location = new System.Drawing.Point(339, 176);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(369, 55);
            this.panel2.TabIndex = 15;
            // 
            // textBoxDolar
            // 
            this.textBoxDolar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDolar.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxDolar.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDolar.Location = new System.Drawing.Point(10, 10);
            this.textBoxDolar.Margin = new System.Windows.Forms.Padding(17, 6, 17, 6);
            this.textBoxDolar.Name = "textBoxDolar";
            this.textBoxDolar.Size = new System.Drawing.Size(349, 33);
            this.textBoxDolar.TabIndex = 12;
            this.textBoxDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDolar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDolar_KeyPress);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.panel4.Controls.Add(this.textBoxBolivar);
            this.panel4.Location = new System.Drawing.Point(339, 356);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(369, 54);
            this.panel4.TabIndex = 21;
            // 
            // textBoxBolivar
            // 
            this.textBoxBolivar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBolivar.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxBolivar.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBolivar.Location = new System.Drawing.Point(10, 10);
            this.textBoxBolivar.Margin = new System.Windows.Forms.Padding(17, 6, 17, 6);
            this.textBoxBolivar.Name = "textBoxBolivar";
            this.textBoxBolivar.ReadOnly = true;
            this.textBoxBolivar.Size = new System.Drawing.Size(349, 33);
            this.textBoxBolivar.TabIndex = 12;
            this.textBoxBolivar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBolivar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBolivar_KeyPress);
            // 
            // labelBol
            // 
            this.labelBol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.labelBol.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBol.ForeColor = System.Drawing.Color.White;
            this.labelBol.Location = new System.Drawing.Point(339, 315);
            this.labelBol.Name = "labelBol";
            this.labelBol.Size = new System.Drawing.Size(369, 45);
            this.labelBol.TabIndex = 20;
            this.labelBol.Text = "BOLÍVAR";
            this.labelBol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSwap
            // 
            this.buttonSwap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSwap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.buttonSwap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.buttonSwap.FlatAppearance.BorderSize = 2;
            this.buttonSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwap.Image = ((System.Drawing.Image)(resources.GetObject("buttonSwap.Image")));
            this.buttonSwap.Location = new System.Drawing.Point(340, 254);
            this.buttonSwap.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(369, 49);
            this.buttonSwap.TabIndex = 2;
            this.buttonSwap.UseVisualStyleBackColor = false;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(339, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 88);
            this.label3.TabIndex = 15;
            this.label3.Text = "CALCULADORA DÓLAR-BOLÍVAR";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TasaDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(718, 433);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonSwap);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.labelBol);
            this.Controls.Add(this.labelDol);
            this.Controls.Add(this.panelSideBar);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TasaDolar";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.Text = "TasaDolar";
            this.Shown += new System.EventHandler(this.TasaDolar_Shown);
            this.panelSideBar.ResumeLayout(false);
            this.panelSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDolares)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInputTasa;
        private System.Windows.Forms.Panel panelSeparator3;
        private System.Windows.Forms.DataGridView dataGridViewDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn Multiplicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label labelDol;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxDolar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxBolivar;
        private System.Windows.Forms.Label labelBol;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.Label label3;
    }
}