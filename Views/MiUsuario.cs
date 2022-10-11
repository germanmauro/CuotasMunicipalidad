using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using BLL;

namespace StockMyG
{
    public partial class MiUsuario : Form
    {
        public MiUsuario()
        {
            InitializeComponent();
        }
        private void banco_Load(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validador.VeficarForm(this))
            {
                if(txtPass.Controls[0].Text == txtPassRepeat.Controls[0].Text)
                {
                    UsuarioService.CambiarPassword(txtPass.Controls[0].Text);

                    this.Close();
                }
                else
                {
                    Utilidades.MensajesAdvertencia("La contraseñas son diferentes");
                }
            }
        }

        #region Metodos
       
        #endregion
    }
}
