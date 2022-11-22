using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace StockMyG
{
    public partial class Inicio : Form
    {
        Session session = Session.GetInstance();
        public Inicio()
        {
            InitializeComponent();
            this.Text += "       " + session.usuario.Descripcion;
            if (session.usuario.perfil_id == 2)
            {
                usuariosToolStripMenuItem.Visible = false;
                bajaDeInvetarioToolStripMenuItem.Visible = false;
            }
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if(MessageBox.Show("Desea cerrar el programa","Salir",MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
                this.Close();
            //}
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            //if(BLL.Validador.Validar())
            //{
            this.menuStrip1.Enabled = true;
            //}
            //else
            //{
            //    this.menuStrip1.Enabled = false;
            //    Validar cli = new Validar
            //    {
            //        MdiParent = this
            //    };
            //    cli.Show();
            //}
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor cli = new Proveedor
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea cerrar el programa", "Salir", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banco cli = new Banco
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void oficinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oficina cli = new Oficina
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Proveedor cli = new Proveedor
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void miUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MiUsuario cli = new MiUsuario
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Municipalidad cli = new Municipalidad
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras cli = new Compras
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void pagoDeCuotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuotasPagar cli = new CuotasPagar
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void cuotasPagadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuotasPagadas cli = new CuotasPagadas
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void reportePorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteIngresos cli = new ReporteIngresos
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void egresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEgresos cli = new ReporteEgresos
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void ingresoDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario cli = new Inventario
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void bajaDeInvetarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventarioBaja cli = new InventarioBaja
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte form = new Reporte();
            form.Show();
            form.CargaInventario();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios cli = new Usuarios
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void municipalidadesComunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Municipalidad cli = new Municipalidad
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void respaldoDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Respaldo cli = new Respaldo
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void cargaDeCuotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargaCuotas cli = new CargaCuotas
            {
                MdiParent = this
            };
            cli.Show();
        }
    }
}
