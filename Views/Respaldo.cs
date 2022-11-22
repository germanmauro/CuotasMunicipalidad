using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Datos;

namespace StockMyG
{
    public partial class Respaldo : Form
    {
        public Respaldo()
        {
            InitializeComponent();
        }
        Formulario.EstadoForm estado;
        private void form_Load(object sender, EventArgs e)
        {
        }

      
    

        private void Oficina_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
               
                case Keys.F5:
                    if (btnGuardar.Enabled)
                    {
                        btnGuardar_Click(null, null);
                    }
                    break;

                default:
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                btnGuardar.Enabled = false;
                btnGuardar.Text = "Generado back up ...";
                if(RespaldoService.GenerarBackUp(folderBrowserDialog1.SelectedPath))
                {
                    this.Close();
                }
            }
        }
    }
}
