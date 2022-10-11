using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace UserControls
{
    public enum Tipo
    {
        Texto = 0,
        Email,
        Numero,
        DNI,
        Decimal,
        Password
    }
    public partial class TextBox : UserControl
    {
        CategoryAttribute Personalizado;
        public bool Obligatorio { get; set; }
        //public bool Correcto { get; set; }
        public Tipo Tipo{ get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Nombre { get; set; }
        public TextBox()
        {
            InitializeComponent();
        }
        public string EsCorrecto()
        {
            string regularexp;
            Regex rg;
            if (Obligatorio)
            {
                if (this.textBox1.Text == "")
                    return "El campo " + this.Nombre + " no puede estar vacío" + Environment.NewLine;
            }
            if (this.textBox1.Text.Length > 0)
            {
                switch (Tipo)
                {
                    case Tipo.Texto:
                    case Tipo.Password:
                        return "";
                    case Tipo.Numero:
                        regularexp = "^[0-9]{" + this.Min.ToString() + "," + this.Max.ToString() + "}$";
                        rg = new Regex(regularexp);
                        if(rg.IsMatch(this.textBox1.Text))
                        { 
                            return "";
                        }
                        else
                        {
                            return "El campo " + this.Nombre + " tiene valores incorrectos" + Environment.NewLine;
                        }
                    case Tipo.Email:
                        regularexp = "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";
                        rg = new Regex(regularexp);
                        if (rg.IsMatch(this.textBox1.Text))
                        {
                            return "";
                        }
                        else
                        {
                            return "El campo " + this.Nombre + " tiene valores incorrectos" + Environment.NewLine;
                        }
                    case Tipo.DNI:
                        regularexp = "^[0-9/-]{" + this.Min.ToString() + "," + this.Max.ToString() + "}$";
                        rg = new Regex(regularexp);
                        if (rg.IsMatch(this.textBox1.Text))
                        {
                            return "";
                        }
                        else
                        {
                            return "El campo " + this.Nombre + " tiene valores incorrectos" + Environment.NewLine;
                        }
                    case Tipo.Decimal:
                        regularexp = "^[0-9]{1,10}(,[0-9]{1,10}){0,1}$";
                        rg = new Regex(regularexp);
                        if (rg.IsMatch(this.textBox1.Text))
                        {
                            if(this.textBox1.Text.Length <= this.Max && this.textBox1.Text.Length >= this.Min)
                                return "";
                            else
                                return "El campo " + this.Nombre + " tiene valores incorrectos" + Environment.NewLine;
                        }
                        else
                        {
                            return "El campo " + this.Nombre + " tiene valores incorrectos" + Environment.NewLine;
                        }
                    default:
                        return "";

                }
            }
            else
            {
                return "";
            }
        }

        private void textBox1_Resize(object sender, EventArgs e)
        {
            this.textBox1.Width = this.Width;
            this.textBox1.Height = this.Height;
        }

        private void TextBox_SizeChanged(object sender, EventArgs e)
        {
            this.textBox1.Width = this.Width;
            this.textBox1.Height = this.Height;
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if(this.textBox1.Text.Length>=this.Max && e.KeyChar.ToString() != "\b")
            {
                e.Handled = true;
            }
            switch (Tipo)
            {
                case Tipo.Texto:
                    break;
                case Tipo.Email:
                    break;
                case Tipo.Numero:
                    if(char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == "\b")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case Tipo.DNI:
                    if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == "\b")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case Tipo.Decimal:
                    if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == "\b" || (e.KeyChar.ToString() == "," && !this.textBox1.Text.Contains(",")))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                default:
                    break;
            }
        }

        private void TextBox_Load(object sender, EventArgs e)
        {
            if(Tipo == Tipo.Password)
            {
                this.textBox1.PasswordChar = '*';
            }
        }
    }
}
