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
            this.groupInformacion = new System.Windows.Forms.GroupBox();
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
            this.btnCuotas = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtMonto = new UserControls.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVencimiento = new UserControls.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPorcentajeAumento = new UserControls.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaAumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupInformacion.Location = new System.Drawing.Point(559, 192);
            this.groupInformacion.Name = "groupInformacion";
            this.groupInformacion.Size = new System.Drawing.Size(302, 353);
            this.groupInformacion.TabIndex = 27;
            this.groupInformacion.TabStop = false;
            this.groupInformacion.Text = "Información";
            // 
            // cmbCondicion
            // 
            this.cmbCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondicion.FormattingEnabled = true;
            this.cmbCondicion.Location = new System.Drawing.Point(130, 158);
            this.cmbCondicion.Name = "cmbCondicion";
            this.cmbCondicion.Size = new System.Drawing.Size(159, 21);
            this.cmbCondicion.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Condición IVA";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(130, 132);
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
            this.label5.Location = new System.Drawing.Point(5, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefono";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 107);
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
            this.label4.Location = new System.Drawing.Point(5, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(130, 82);
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
            this.label3.Location = new System.Drawing.Point(5, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dirección";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(130, 57);
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
            this.label2.Location = new System.Drawing.Point(5, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CUIT";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 30);
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
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(82, 310);
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
            this.DiaAumento,
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
            this.Grid.Location = new System.Drawing.Point(2, 11);
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
            this.Grid.Size = new System.Drawing.Size(552, 534);
            this.Grid.TabIndex = 26;
            this.Grid.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
            // 
            // btnCuotas
            // 
            this.btnCuotas.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCuotas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuotas.Location = new System.Drawing.Point(631, 150);
            this.btnCuotas.Name = "btnCuotas";
            this.btnCuotas.Size = new System.Drawing.Size(146, 27);
            this.btnCuotas.TabIndex = 32;
            this.btnCuotas.Text = "CUOTAS [F6]";
            this.btnCuotas.UseVisualStyleBackColor = false;
            this.btnCuotas.Click += new System.EventHandler(this.btnCuotas_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(631, 103);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 27);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "ELIMINAR [F4]";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnModificar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(631, 57);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(146, 27);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "MODIFICAR [F3]";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNuevo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(631, 11);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(146, 27);
            this.btnNuevo.TabIndex = 31;
            this.btnNuevo.Text = "NUEVO [F2]";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(130, 188);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Monto Cuota";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Día de Vencimiento";
            // 
            // txtVencimiento
            // 
            this.txtVencimiento.Location = new System.Drawing.Point(130, 218);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Porcentaje Aumento";
            // 
            // txtPorcentajeAumento
            // 
            this.txtPorcentajeAumento.Location = new System.Drawing.Point(130, 247);
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
            // DiaAumento
            // 
            this.DiaAumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaAumento.DataPropertyName = "DiaAumento";
            this.DiaAumento.HeaderText = "Día Aumento";
            this.DiaAumento.Name = "DiaAumento";
            this.DiaAumento.ReadOnly = true;
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
            this.Controls.Add(this.btnCuotas);
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
            this.Text = "Administración de Municipalidades";
            this.Load += new System.EventHandler(this.Proveedor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Producto_KeyDown);
            this.groupInformacion.ResumeLayout(false);
            this.groupInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnCuotas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private UserControls.TextBox txtPorcentajeAumento;
        private UserControls.TextBox txtVencimiento;
        private UserControls.TextBox txtMonto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaAumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeAumento;
    }
}