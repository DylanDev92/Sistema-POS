namespace Sistema_POS
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSeparator3 = new System.Windows.Forms.Panel();
            this.textBoxInputCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxNoPrecio = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxImpuestos = new System.Windows.Forms.ComboBox();
            this.checkBoxPeso = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxBolivares = new System.Windows.Forms.TextBox();
            this.textBoxDolares = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanelCodigo = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonClean = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonMultiplicar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelDolares = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelIVA = new System.Windows.Forms.Label();
            this.labelExento = new System.Windows.Forms.Label();
            this.labelBaseImponible = new System.Windows.Forms.Label();
            this.panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelCodigo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.panelSideBar.Controls.Add(this.dataGridViewProductos);
            this.panelSideBar.Controls.Add(this.panelSeparator3);
            this.panelSideBar.Controls.Add(this.textBoxInputCode);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Padding = new System.Windows.Forms.Padding(17, 22, 17, 0);
            this.panelSideBar.Size = new System.Drawing.Size(380, 415);
            this.panelSideBar.TabIndex = 1;
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
            this.dataGridViewProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewProductos.RowHeadersVisible = false;
            this.dataGridViewProductos.RowTemplate.Height = 30;
            this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.Size = new System.Drawing.Size(346, 340);
            this.dataGridViewProductos.TabIndex = 12;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick);
            this.dataGridViewProductos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentDoubleClick);
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
            this.Precio.FillWeight = 81.99161F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
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
            this.textBoxInputCode.Enter += new System.EventHandler(this.textBoxInputCode_Enter);
            this.textBoxInputCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInputCode_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(380, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 21);
            this.panel1.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel3.Controls.Add(this.checkBoxNoPrecio, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxImpuestos, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxPeso, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(380, 183);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.96227F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.03773F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(321, 56);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // checkBoxNoPrecio
            // 
            this.checkBoxNoPrecio.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxNoPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxNoPrecio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNoPrecio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxNoPrecio.Location = new System.Drawing.Point(188, 22);
            this.checkBoxNoPrecio.Name = "checkBoxNoPrecio";
            this.checkBoxNoPrecio.Size = new System.Drawing.Size(130, 31);
            this.checkBoxNoPrecio.TabIndex = 17;
            this.checkBoxNoPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxNoPrecio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxNoPrecio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Impuesto";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(88, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "¿Se pesa?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxImpuestos
            // 
            this.comboBoxImpuestos.AllowDrop = true;
            this.comboBoxImpuestos.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxImpuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxImpuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxImpuestos.FormattingEnabled = true;
            this.comboBoxImpuestos.Items.AddRange(new object[] {
            "16%",
            "12%",
            "8%",
            "Exento"});
            this.comboBoxImpuestos.Location = new System.Drawing.Point(15, 24);
            this.comboBoxImpuestos.Margin = new System.Windows.Forms.Padding(15, 5, 10, 5);
            this.comboBoxImpuestos.Name = "comboBoxImpuestos";
            this.comboBoxImpuestos.Size = new System.Drawing.Size(63, 27);
            this.comboBoxImpuestos.TabIndex = 14;
            this.comboBoxImpuestos.SelectedValueChanged += new System.EventHandler(this.comboBoxImpuestos_SelectedValueChanged);
            this.comboBoxImpuestos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxImpuestos_KeyPress);
            // 
            // checkBoxPeso
            // 
            this.checkBoxPeso.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPeso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxPeso.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPeso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxPeso.Location = new System.Drawing.Point(91, 22);
            this.checkBoxPeso.Name = "checkBoxPeso";
            this.checkBoxPeso.Size = new System.Drawing.Size(91, 31);
            this.checkBoxPeso.TabIndex = 15;
            this.checkBoxPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPeso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxPeso.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(185, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(136, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "¿Precio sin asignar?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxBolivares, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDolares, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(380, 127);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.96227F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.03773F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(321, 56);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // textBoxBolivares
            // 
            this.textBoxBolivares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBolivares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBolivares.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBolivares.Location = new System.Drawing.Point(17, 25);
            this.textBoxBolivares.Margin = new System.Windows.Forms.Padding(17, 6, 17, 6);
            this.textBoxBolivares.Name = "textBoxBolivares";
            this.textBoxBolivares.Size = new System.Drawing.Size(121, 24);
            this.textBoxBolivares.TabIndex = 12;
            this.textBoxBolivares.Enter += new System.EventHandler(this.textBoxBolivares_Enter);
            this.textBoxBolivares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBolivares_KeyPress);
            this.textBoxBolivares.Leave += new System.EventHandler(this.textBoxBolivares_Leave);
            // 
            // textBoxDolares
            // 
            this.textBoxDolares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDolares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDolares.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDolares.Location = new System.Drawing.Point(172, 25);
            this.textBoxDolares.Margin = new System.Windows.Forms.Padding(17, 6, 17, 6);
            this.textBoxDolares.Name = "textBoxDolares";
            this.textBoxDolares.Size = new System.Drawing.Size(132, 24);
            this.textBoxDolares.TabIndex = 11;
            this.textBoxDolares.TextChanged += new System.EventHandler(this.textBoxDolares_TextChanged);
            this.textBoxDolares.Enter += new System.EventHandler(this.textBoxDolares_Enter);
            this.textBoxDolares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDolares_KeyPress_1);
            this.textBoxDolares.Leave += new System.EventHandler(this.textBoxDolares_Leave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(155, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Precio Bolivares:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(155, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(166, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Precio Dólares:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxDescripcion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(380, 74);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.96227F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.03773F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 53);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescripcion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcion.Location = new System.Drawing.Point(17, 24);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(17, 6, 17, 6);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(287, 24);
            this.textBoxDescripcion.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(321, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelCodigo
            // 
            this.tableLayoutPanelCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.tableLayoutPanelCodigo.ColumnCount = 1;
            this.tableLayoutPanelCodigo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCodigo.Controls.Add(this.textBoxCodigo, 0, 1);
            this.tableLayoutPanelCodigo.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelCodigo.Location = new System.Drawing.Point(380, 21);
            this.tableLayoutPanelCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelCodigo.Name = "tableLayoutPanelCodigo";
            this.tableLayoutPanelCodigo.RowCount = 2;
            this.tableLayoutPanelCodigo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.96227F));
            this.tableLayoutPanelCodigo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.03773F));
            this.tableLayoutPanelCodigo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCodigo.Size = new System.Drawing.Size(321, 53);
            this.tableLayoutPanelCodigo.TabIndex = 13;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCodigo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.Location = new System.Drawing.Point(17, 24);
            this.textBoxCodigo.Margin = new System.Windows.Forms.Padding(17, 6, 17, 6);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(287, 24);
            this.textBoxCodigo.TabIndex = 11;
            this.textBoxCodigo.TextChanged += new System.EventHandler(this.textBoxCodigo_TextChanged);
            this.textBoxCodigo.Enter += new System.EventHandler(this.textBoxCodigo_Enter);
            this.textBoxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodigo_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(321, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(380, 239);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 20);
            this.panel2.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.panel4.Controls.Add(this.buttonClean);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.buttonMultiplicar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(568, 259);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(133, 156);
            this.panel4.TabIndex = 19;
            // 
            // buttonClean
            // 
            this.buttonClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.buttonClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClean.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClean.FlatAppearance.BorderSize = 0;
            this.buttonClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClean.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClean.ForeColor = System.Drawing.Color.White;
            this.buttonClean.Image = ((System.Drawing.Image)(resources.GetObject("buttonClean.Image")));
            this.buttonClean.Location = new System.Drawing.Point(5, 103);
            this.buttonClean.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(123, 39);
            this.buttonClean.TabIndex = 21;
            this.buttonClean.Text = "  Limpiar";
            this.buttonClean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClean.UseVisualStyleBackColor = false;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(5, 93);
            this.panel6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(123, 10);
            this.panel6.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(5, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 39);
            this.button1.TabIndex = 19;
            this.button1.Text = "  Eliminar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 44);
            this.panel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(123, 10);
            this.panel5.TabIndex = 18;
            // 
            // buttonMultiplicar
            // 
            this.buttonMultiplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.buttonMultiplicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMultiplicar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMultiplicar.FlatAppearance.BorderSize = 0;
            this.buttonMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiplicar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplicar.ForeColor = System.Drawing.Color.White;
            this.buttonMultiplicar.Image = ((System.Drawing.Image)(resources.GetObject("buttonMultiplicar.Image")));
            this.buttonMultiplicar.Location = new System.Drawing.Point(5, 5);
            this.buttonMultiplicar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMultiplicar.Name = "buttonMultiplicar";
            this.buttonMultiplicar.Size = new System.Drawing.Size(123, 39);
            this.buttonMultiplicar.TabIndex = 6;
            this.buttonMultiplicar.Text = "  Actualizar";
            this.buttonMultiplicar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMultiplicar.UseVisualStyleBackColor = false;
            this.buttonMultiplicar.Click += new System.EventHandler(this.buttonMultiplicar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.panel3.Controls.Add(this.labelDolares);
            this.panel3.Controls.Add(this.labelTotal);
            this.panel3.Controls.Add(this.labelIVA);
            this.panel3.Controls.Add(this.labelExento);
            this.panel3.Controls.Add(this.labelBaseImponible);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(380, 259);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(188, 156);
            this.panel3.TabIndex = 20;
            // 
            // labelDolares
            // 
            this.labelDolares.AutoSize = true;
            this.labelDolares.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDolares.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDolares.ForeColor = System.Drawing.Color.White;
            this.labelDolares.Location = new System.Drawing.Point(15, 113);
            this.labelDolares.Name = "labelDolares";
            this.labelDolares.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelDolares.Size = new System.Drawing.Size(64, 24);
            this.labelDolares.TabIndex = 4;
            this.labelDolares.Text = "Dólares:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTotal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(15, 72);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.labelTotal.Size = new System.Drawing.Size(59, 41);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Total:";
            // 
            // labelIVA
            // 
            this.labelIVA.AutoSize = true;
            this.labelIVA.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelIVA.ForeColor = System.Drawing.Color.White;
            this.labelIVA.Location = new System.Drawing.Point(15, 53);
            this.labelIVA.Name = "labelIVA";
            this.labelIVA.Size = new System.Drawing.Size(35, 19);
            this.labelIVA.TabIndex = 2;
            this.labelIVA.Text = "IVA:";
            // 
            // labelExento
            // 
            this.labelExento.AutoSize = true;
            this.labelExento.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelExento.ForeColor = System.Drawing.Color.White;
            this.labelExento.Location = new System.Drawing.Point(15, 34);
            this.labelExento.Name = "labelExento";
            this.labelExento.Size = new System.Drawing.Size(60, 19);
            this.labelExento.TabIndex = 1;
            this.labelExento.Text = "Exento:";
            // 
            // labelBaseImponible
            // 
            this.labelBaseImponible.AutoSize = true;
            this.labelBaseImponible.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBaseImponible.ForeColor = System.Drawing.Color.White;
            this.labelBaseImponible.Location = new System.Drawing.Point(15, 15);
            this.labelBaseImponible.Name = "labelBaseImponible";
            this.labelBaseImponible.Size = new System.Drawing.Size(44, 19);
            this.labelBaseImponible.TabIndex = 0;
            this.labelBaseImponible.Text = "Base:";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(718, 433);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanelCodigo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideBar);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Productos";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 17, 18);
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.Shown += new System.EventHandler(this.Productos_Shown);
            this.panelSideBar.ResumeLayout(false);
            this.panelSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelCodigo.ResumeLayout(false);
            this.tableLayoutPanelCodigo.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.TextBox textBoxInputCode;
        private System.Windows.Forms.Panel panelSeparator3;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxImpuestos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxBolivares;
        private System.Windows.Forms.TextBox textBoxDolares;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCodigo;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxPeso;
        private System.Windows.Forms.CheckBox checkBoxNoPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelIVA;
        private System.Windows.Forms.Label labelExento;
        private System.Windows.Forms.Label labelBaseImponible;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelDolares;
        private System.Windows.Forms.Button buttonMultiplicar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}