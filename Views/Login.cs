using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMyG
{
    public partial class Login : Form
    {


        BLL.LoginService login_service;
        public Login()
        {
            InitializeComponent();
            login_service = new BLL.LoginService();
        }

        Formulario.EstadoForm estado;
        private void Categoria_Load(object sender, EventArgs e)
        {
            this.user_txt.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!login_service.Login(this.user_txt.Controls[0].Text, this.password_txt.Text))
            {
                BLL.Utilidades.MensajesAdvertencia("Usuario o Contraseña Incorrectos");
            }
            else
            {
                Inicio cli = new Inicio();
                cli.Show();
                this.Hide();

            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, new EventArgs());
            }
        }
    }
}
