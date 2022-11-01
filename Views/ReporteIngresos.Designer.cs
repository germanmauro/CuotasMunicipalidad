namespace StockMyG
{
    partial class ReporteIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteIngresos));
            this.grpRepuestos = new System.Windows.Forms.GroupBox();
            this.hasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.desde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbMunicipalidad = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpRepuestos.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRepuestos
            // 
            this.grpRepuestos.Controls.Add(this.hasta);
            this.grpRepuestos.Controls.Add(this.label2);
            this.grpRepuestos.Controls.Add(this.desde);
            this.grpRepuestos.Controls.Add(this.label1);
            this.grpRepuestos.Controls.Add(this.groupBox6);
            this.grpRepuestos.Controls.Add(this.btnBuscar);
            this.grpRepuestos.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRepuestos.Location = new System.Drawing.Point(12, 12);
            this.grpRepuestos.Name = "grpRepuestos";
            this.grpRepuestos.Size = new System.Drawing.Size(460, 273);
            this.grpRepuestos.TabIndex = 41;
            this.grpRepuestos.TabStop = false;
            this.grpRepuestos.Text = "SELECCIONE LOS FILTROS PARA VER EL REPORTE";
            // 
            // hasta
            // 
            this.hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hasta.Location = new System.Drawing.Point(347, 41);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(99, 21);
            this.hasta.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Fecha Desde";
            // 
            // desde
            // 
            this.desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.desde.Location = new System.Drawing.Point(114, 41);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(99, 21);
            this.desde.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Fecha Desde";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmbMunicipalidad);
            this.groupBox6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(79, 94);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(306, 56);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "MUNICIPALIDAD / COMUNA";
            // 
            // cmbMunicipalidad
            // 
            this.cmbMunicipalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMunicipalidad.FormattingEnabled = true;
            this.cmbMunicipalidad.Location = new System.Drawing.Point(19, 20);
            this.cmbMunicipalidad.Name = "cmbMunicipalidad";
            this.cmbMunicipalidad.Size = new System.Drawing.Size(268, 21);
            this.cmbMunicipalidad.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(171, 193);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 45);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ReporteIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 293);
            this.Controls.Add(this.grpRepuestos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteIngresos";
            this.ShowIcon = false;
            this.Text = "Reporte de ingresos";
            this.Load += new System.EventHandler(this.ReporteVehiculo_Load);
            this.grpRepuestos.ResumeLayout(false);
            this.grpRepuestos.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRepuestos;
        private System.Windows.Forms.DateTimePicker hasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker desde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmbMunicipalidad;
        private System.Windows.Forms.Button btnBuscar;
    }
}