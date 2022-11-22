namespace StockMyG
{
    partial class Municipalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Municipalidad));
            this.groupInformacion = new System.Windows.Forms.GroupBox();
            this.txtPorcentajeAumento = new UserControls.TextBox();
            this.txtVencimiento = new UserControls.TextBox();
            this.txtMonto = new UserControls.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCondicion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new UserControls.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new UserControls.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new UserControls.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCUIT = new UserControls.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new UserControls.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnIngresos = new System.Windows.Forms.Button();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeAumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupInformacion
            // 
            this.groupInformacion.Controls.Add(this.txtPorcentajeAumento);
            this.groupInformacion.Controls.Add(this.txtVencimiento);
            this.groupInformacion.Controls.Add(this.txtMonto);
            this.groupInformacion.Controls.Add(this.label9);
            this.groupInformacion.Controls.Add(this.label8);
            this.groupInformacion.Controls.Add(this.label7);
            this.groupInformacion.Controls.Add(this.cmbCondicion);
            this.groupInformacion.Controls.Add(this.label6);
            this.groupInformacion.Controls.Add(this.txtTelefono);
            this.groupInformacion.Controls.Add(this.label5);
            this.groupInformacion.Controls.Add(this.txtEmail);
            this.groupInformacion.Controls.Add(this.label4);
            this.groupInformacion.Controls.Add(this.txtDireccion);
            this.groupInformacion.Controls.Add(this.label3);
            this.groupInformacion.Controls.Add(this.txtCUIT);
            this.groupInformacion.Controls.Add(this.label2);
            this.groupInformacion.Controls.Add(this.txtNombre);
            this.groupInformacion.Controls.Add(this.label1);
            this.groupInformacion.Controls.Add(this.btnGuardar);
            this.groupInformacion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInformacion.Location = new System.Drawing.Point(559, 214);
            this.groupInformacion.Name = "groupInformacion";
            this.groupInformacion.Size = new System.Drawing.Size(302, 331);
            this.groupInformacion.TabIndex = 27;
            this.groupInformacion.TabStop = false;
            this.groupInformacion.Text = "Información";
            // 
            // txtPorcentajeAumento
            // 
            this.txtPorcentajeAumento.Location = new System.Drawing.Point(130, 245);
            this.txtPorcentajeAumento.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtPorcentajeAumento.Max = 300;
            this.txtPorcentajeAumento.Min = 0;
            this.txtPorcentajeAumento.Name = "txtPorcentajeAumento";
            this.txtPorcentajeAumento.Nombre = "Porcentaje de aumento";
            this.txtPorcentajeAumento.Obligatorio = true;
            this.txtPorcentajeAumento.Size = new System.Drawing.Size(159, 19);
            this.txtPorcentajeAumento.TabIndex = 8;
            this.txtPorcentajeAumento.Tipo = UserControls.Tipo.Decimal;
            // 
            // txtVencimiento
            // 
            this.txtVencimiento.Location = new System.Drawing.Point(130, 216);
            this.txtVencimiento.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtVencimiento.Max = 30;
            this.txtVencimiento.Min = 1;
            this.txtVencimiento.Name = "txtVencimiento";
            this.txtVencimiento.Nombre = "Día Vencimiento";
            this.txtVencimiento.Obligatorio = true;
            this.txtVencimiento.Size = new System.Drawing.Size(159, 19);
            this.txtVencimiento.TabIndex = 8;
            this.txtVencimiento.Tipo = UserControls.Tipo.Numero;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(130, 186);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMonto.Max = 1000000;
            this.txtMonto.Min = 1;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Nombre = "Monto Cuota";
            this.txtMonto.Obligatorio = true;
            this.txtMonto.Size = new System.Drawing.Size(159, 19);
            this.txtMonto.TabIndex = 8;
            this.txtMonto.Tipo = UserControls.Tipo.Decimal;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Porcentaje Aumento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Día de Vencimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Monto Cuota";
            // 
            // cmbCondicion
            // 
            this.cmbCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondicion.FormattingEnabled = true;
            this.cmbCondicion.Location = new System.Drawing.Point(130, 156);
            this.cmbCondicion.Name = "cmbCondicion";
            this.cmbCondicion.Size = new System.Drawing.Size(159, 21);
            this.cmbCondicion.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Condición IVA";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(130, 130);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTelefono.Max = 30;
            this.txtTelefono.Min = 0;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Nombre = "Teléfono";
            this.txtTelefono.Obligatorio = false;
            this.txtTelefono.Size = new System.Drawing.Size(159, 19);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.Tipo = UserControls.Tipo.Texto;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefono";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 105);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Max = 100;
            this.txtEmail.Min = 0;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Nombre = "Email";
            this.txtEmail.Obligatorio = false;
            this.txtEmail.Size = new System.Drawing.Size(159, 19);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Tipo = UserControls.Tipo.Email;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(130, 80);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDireccion.Max = 200;
            this.txtDireccion.Min = 0;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Nombre = "Dirección";
            this.txtDireccion.Obligatorio = false;
            this.txtDireccion.Size = new System.Drawing.Size(159, 19);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.Tipo = UserControls.Tipo.Texto;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dirección";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(130, 55);
            this.txtCUIT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCUIT.Max = 20;
            this.txtCUIT.Min = 0;
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Nombre = "CUIT";
            this.txtCUIT.Obligatorio = false;
            this.txtCUIT.Size = new System.Drawing.Size(159, 19);
            this.txtCUIT.TabIndex = 2;
            this.txtCUIT.Tipo = UserControls.Tipo.Texto;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CUIT";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 28);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Max = 25;
            this.txtNombre.Min = 0;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Nombre = "Nombre";
            this.txtNombre.Obligatorio = true;
            this.txtNombre.Size = new System.Drawing.Size(159, 19);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Tipo = UserControls.Tipo.Texto;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(82, 293);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 27);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "GUARDAR [F5]";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeColumns = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.CUIT,
            this.Direccion,
            this.Telefono,
            this.Email,
            this.Condicion,
            this.MontoCuota,
            this.DiaVencimiento,
            this.PorcentajeAumento});
            this.Grid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.Location = new System.Drawing.Point(2, 45);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid.RowHeadersVisible = false;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(552, 500);
            this.Grid.TabIndex = 26;
            this.Grid.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(631, 113);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 27);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "ELIMINAR [F4]";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnModificar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(631, 80);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(146, 27);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "MODIFICAR [F3]";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNuevo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(631, 45);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(146, 27);
            this.btnNuevo.TabIndex = 31;
            this.btnNuevo.Text = "NUEVO [F2]";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnIngresos
            // 
            this.btnIngresos.BackColor = System.Drawing.Color.Gainsboro;
            this.btnIngresos.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresos.Location = new System.Drawing.Point(631, 149);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(146, 27);
            this.btnIngresos.TabIndex = 33;
            this.btnIngresos.Text = "INGRESOS [F7]";
            this.btnIngresos.UseVisualStyleBackColor = false;
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMovimientos.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimientos.Location = new System.Drawing.Point(631, 184);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Size = new System.Drawing.Size(146, 27);
            this.btnMovimientos.TabIndex = 34;
            this.btnMovimientos.Text = "MOVIMIENTOS [F8]";
            this.btnMovimientos.UseVisualStyleBackColor = false;
            this.btnMovimientos.Click += new System.EventHandler(this.btnMovimientos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(405, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(28, 27);
            this.btnBuscar.TabIndex = 47;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(182, 8);
            this.txtFiltro.MaxLength = 30;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(208, 20);
            this.txtFiltro.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "Filtrar por nombre";
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Codigo";
            this.id.MinimumWidth = 2;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 2;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // CUIT
            // 
            this.CUIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUIT.DataPropertyName = "CUIT";
            this.CUIT.HeaderText = "CUIT";
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Condicion
            // 
            this.Condicion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Condicion.DataPropertyName = "Condicion";
            this.Condicion.HeaderText = "Condicion IVA";
            this.Condicion.Name = "Condicion";
            this.Condicion.ReadOnly = true;
            // 
            // MontoCuota
            // 
            this.MontoCuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MontoCuota.DataPropertyName = "MontoCuota";
            this.MontoCuota.HeaderText = "Monto Cuota";
            this.MontoCuota.Name = "MontoCuota";
            this.MontoCuota.ReadOnly = true;
            // 
            // DiaVencimiento
            // 
            this.DiaVencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaVencimiento.DataPropertyName = "DiaVencimiento";
            this.DiaVencimiento.HeaderText = "Día Vencimiento";
            this.DiaVencimiento.Name = "DiaVencimiento";
            this.DiaVencimiento.ReadOnly = true;
            // 
            // PorcentajeAumento
            // 
            this.PorcentajeAumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PorcentajeAumento.DataPropertyName = "PorcentajeAumento";
            this.PorcentajeAumento.HeaderText = "% Aumento";
            this.PorcentajeAumento.Name = "PorcentajeAumento";
            this.PorcentajeAumento.ReadOnly = true;
            // 
            // Municipalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(864, 557);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnMovimientos);
            this.Controls.Add(this.btnIngresos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupInformacion);
            this.Controls.Add(this.Grid);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Municipalidad";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Municipalidades / Comunas";
            this.Load += new System.EventHandler(this.Proveedor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Producto_KeyDown);
            this.groupInformacion.ResumeLayout(false);
            this.groupInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInformacion;
        private UserControls.TextBox txtCUIT;
        private System.Windows.Forms.Label label2;
        private UserControls.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView Grid;
        private UserControls.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private UserControls.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private UserControls.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCondicion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private UserControls.TextBox txtPorcentajeAumento;
        private UserControls.TextBox txtVencimiento;
        private UserControls.TextBox txtMonto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIngresos;
        private System.Windows.Forms.Button btnMovimientos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeAumento;
    }
}