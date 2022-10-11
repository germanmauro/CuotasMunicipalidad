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

namespace StockMyG
{
    public partial class Inicio : Form
    {
        Session session = Session.GetInstance();
        public Inicio()
        {
            InitializeComponent();
            this.Text += "       " + session.usuario.Descripcion;
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if(MessageBox.Show("Desea cerrar el programa","Salir",MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
                this.Close();
            //}
        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente
            {
                MdiParent = this
            };
            cli.Show();
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

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Categoria cli = new Categoria
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void subCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubCategorias cli = new SubCategorias
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Productos cli = new Productos
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor cli = new Proveedor
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color cli = new Color
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Venta cli = new Venta
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerRecibos cli = new VerRecibos
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void reportePorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteProductos cli = new ReporteProductos
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido_a_proveedores cli = new Pedido_a_proveedores
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void actualizarProductosPorPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargaPedido cli = new CargaPedido
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

        private void coloresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Color cli = new Color
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void talllesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Talle cli = new Talle
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void visualizarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerRecibos cli = new VerRecibos
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void listadoDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoPedido cli = new ListadoPedido
            {
                MdiParent = this
            };
            cli.Show();
        }

        private void categoríasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Categoria cli = new Categoria
            {
                MdiParent = this
            };
            cli.Show();
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

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario cli = new Inventario
            {
                MdiParent = this
            };
            cli.Show();
        }
    }
}
