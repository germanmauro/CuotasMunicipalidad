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
    public partial class ProveedorProducto : Form
    {
        //public Entidades.Proveedor prov { get; set; }

        public ProveedorProducto()
        {
            InitializeComponent();
        }

        private void ActualizarGrilla()
        {
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = false;
            //Grid.DataSource = BLL.ProveedorBLL.ListarProductoIncluidos(this.prov.Codigo);

            //GridNoIncluido.DataSource = BLL.ProveedorBLL.ListarProductoNoIncluidos(this.prov.Codigo);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realizar la eliminación?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Entidades.ProveedorProducto ent = new Entidades.ProveedorProducto(this.prov.Codigo,int.Parse(Grid.SelectedRows[0].Cells["Variante"].Value.ToString()));
                //BLL.ProveedorBLL.EliminarProducto(ent);

                ActualizarGrilla();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Entidades.ProveedorProducto ent = new Entidades.ProveedorProducto(this.prov.Codigo, int.Parse(GridNoIncluido.SelectedRows[0].Cells["Variante1"].Value.ToString()));
            //BLL.ProveedorBLL.AgregarProducto(ent);

            ActualizarGrilla();
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            if (Grid.SelectedRows.Count > 0)
            {
                btnEliminar.Enabled = true;
            }
        }

        private void GridNoIncluido_SelectionChanged(object sender, EventArgs e)
        {
            if (GridNoIncluido.SelectedRows.Count > 0)
            {
                btnAgregar.Enabled = true;
            }
        }

        private void ProveedorProducto_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            //this.label1.Text += this.prov.Nombre;
        }
    }
}
