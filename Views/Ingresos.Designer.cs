namespace StockMyG
{
    partial class Ingresos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupInformacion = new System.Windows.Forms.GroupBox();
            this.cmbBanco = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtImporte = new UserControls.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new UserControls.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Municipalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupInformacion
            // 
            this.groupInformacion.Controls.Add(this.cmbBanco);
            this.groupInformacion.Controls.Add(this.label7);
            this.groupInformacion.Controls.Add(this.dateTimePicker1);
            this.groupInformacion.Controls.Add(this.txtImporte);
            this.groupInformacion.Controls.Add(this.label4);
            this.groupInformacion.Controls.Add(this.cmbFormaPago);
            this.groupInformacion.Controls.Add(this.label5);
            this.groupInformacion.Controls.Add(this.label2);
            this.groupInformacion.Controls.Add(this.txtDescripcion);
            this.groupInformacion.Controls.Add(this.label1);
            this.groupInformacion.Controls.Add(this.btnGuardar);
            this.groupInformacion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInformacion.Location = new System.Drawing.Point(590, 213);
            this.groupInformacion.Name = "groupInformacion";
            this.groupInformacion.Size = new System.Drawing.Size(292, 244);
            this.groupInformacion.TabIndex = 27;
            this.groupInformacion.TabStop = false;
            this.groupInformacion.Text = "Información";
            // 
            // cmbBanco
            // 
            this.cmbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBanco.FormattingEnabled = true;
            this.cmbBanco.Location = new System.Drawing.Point(113, 124);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Size = new System.Drawing.Size(159, 21);
            this.cmbBanco.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Banco";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 156);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 21);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(113, 59);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtImporte.Max = 25;
            this.txtImporte.Min = 0;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Nombre = "Nombre";
            this.txtImporte.Obligatorio = true;
            this.txtImporte.Size = new System.Drawing.Size(161, 19);
            this.txtImporte.TabIndex = 10;
            this.txtImporte.Tipo = UserControls.Tipo.Decimal;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Importe";
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Location = new System.Drawing.Point(113, 91);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(159, 21);
            this.cmbFormaPago.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Forma de Pago";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(113, 26);
            this.txtDescripcion.Max = 25;
            this.txtDescripcion.Min = 0;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Nombre = "Nombre";
            this.txtDescripcion.Obligatorio = true;
            this.txtDescripcion.Size = new System.Drawing.Size(161, 19);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Tipo = UserControls.Tipo.Texto;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripción";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(91, 197);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Fecha,
            this.Municipalidad,
            this.Descripcion,
            this.Importe,
            this.FormaPago,
            this.Banco});
            this.Grid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle8;
            this.Grid.Location = new System.Drawing.Point(2, 38);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Grid.RowHeadersVisible = false;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(579, 423);
            this.Grid.TabIndex = 26;
            this.Grid.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(664, 132);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 27);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "ELIMINAR [F4]";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnModificar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(664, 86);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(146, 27);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "MODIFICAR [F3]";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNuevo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(664, 40);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(146, 27);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.Text = "NUEVO [F2]";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Municipalidad
            // 
            this.Municipalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Municipalidad.DataPropertyName = "Municipalidad";
            this.Municipalidad.HeaderText = "Municipalidad";
            this.Municipalidad.Name = "Municipalidad";
            this.Municipalidad.ReadOnly = true;
            this.Municipalidad.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Importe.DataPropertyName = "Importe";
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // FormaPago
            // 
            this.FormaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FormaPago.DataPropertyName = "FormaPago";
            this.FormaPago.HeaderText = "Forma de Pago";
            this.FormaPago.Name = "FormaPago";
            this.FormaPago.ReadOnly = true;
            // 
            // Banco
            // 
            this.Banco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Banco.DataPropertyName = "Banco";
            this.Banco.HeaderText = "Banco";
            this.Banco.Name = "Banco";
            this.Banco.ReadOnly = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(51, 20);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "label3";
            // 
            // Ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(891, 485);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupInformacion);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ingresos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Ingresos";
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
        private UserControls.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private UserControls.TextBox txtImporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBanco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Municipalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.Label lblTitulo;
    }
}