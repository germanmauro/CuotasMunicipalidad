namespace StockMyG
{
    partial class MiUsuario
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
            this.groupInformacion = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPassRepeat = new UserControls.TextBox();
            this.txtPass = new UserControls.TextBox();
            this.groupInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInformacion
            // 
            this.groupInformacion.Controls.Add(this.txtPassRepeat);
            this.groupInformacion.Controls.Add(this.txtPass);
            this.groupInformacion.Controls.Add(this.label2);
            this.groupInformacion.Controls.Add(this.label1);
            this.groupInformacion.Controls.Add(this.button2);
            this.groupInformacion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInformacion.Location = new System.Drawing.Point(12, 12);
            this.groupInformacion.Name = "groupInformacion";
            this.groupInformacion.Size = new System.Drawing.Size(264, 179);
            this.groupInformacion.TabIndex = 9;
            this.groupInformacion.TabStop = false;
            this.groupInformacion.Text = "Información";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Repetir Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nueva Contraseña";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(27, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 27);
            this.button2.TabIndex = 0;
            this.button2.Text = "MODIFICAR CONTRASEÑA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtPassRepeat
            // 
            this.txtPassRepeat.Location = new System.Drawing.Point(133, 75);
            this.txtPassRepeat.Max = 20;
            this.txtPassRepeat.Min = 0;
            this.txtPassRepeat.Name = "txtPassRepeat";
            this.txtPassRepeat.Nombre = "Repetir Contraseña";
            this.txtPassRepeat.Obligatorio = true;
            this.txtPassRepeat.Size = new System.Drawing.Size(118, 19);
            this.txtPassRepeat.TabIndex = 3;
            this.txtPassRepeat.Tipo = UserControls.Tipo.Password;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(133, 41);
            this.txtPass.Max = 20;
            this.txtPass.Min = 0;
            this.txtPass.Name = "txtPass";
            this.txtPass.Nombre = "Contraseña";
            this.txtPass.Obligatorio = true;
            this.txtPass.Size = new System.Drawing.Size(118, 19);
            this.txtPass.TabIndex = 3;
            this.txtPass.Tipo = UserControls.Tipo.Password;
            // 
            // MiUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(288, 203);
            this.Controls.Add(this.groupInformacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiUsuario";
            this.ShowIcon = false;
            this.Text = "Datos del Usuario";
            this.Load += new System.EventHandler(this.banco_Load);
            this.groupInformacion.ResumeLayout(false);
            this.groupInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInformacion;
        private UserControls.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private UserControls.TextBox txtPassRepeat;
        private System.Windows.Forms.Label label2;
    }
}