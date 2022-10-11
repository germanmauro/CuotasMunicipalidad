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
    public partial class ListadoPedido : Form
    {
        public ListadoPedido()
        {
            InitializeComponent();
        }
        Formulario.EstadoForm estado;
        private void CargaPedido_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            if (this.Grid.SelectedRows.Count > 0)
            {
                estado = Formulario.EstadoForm.Seleccionado;
                //GridDetalle.DataSource = BLL.PedidoBLL.ListarPedidoDetalle(int.Parse(this.Grid.SelectedRows[0].Cells["Codigo"].Value.ToString()));
                ActualizarVista();
            }
        }

        #region Metodos
        private void ActualizarGrilla()
        {
            //this.Grid.DataSource = BLL.PedidoBLL.ListarPedidosTodos();
            estado = Formulario.EstadoForm.SinDatos;
            //Grid.ClearSelection();
            ActualizarVista();
        }

        private void ActualizarVista()
        {
            switch (estado)
            {
                case Formulario.EstadoForm.SinDatos:
                    //btnFactura.Enabled = false;
                    this.btnRecibo.Enabled = false;
                    this.Grid.ClearSelection();
                    break;
                case Formulario.EstadoForm.Seleccionado:
                    //btnFactura.Enabled = true;
                    btnRecibo.Enabled = true;
                    break;
                case Formulario.EstadoForm.Nuevo:
                    break;
                case Formulario.EstadoForm.Modificado:
                    break;
                default:
                    break;
            }
        }

        #endregion

        private void btnRecibo_Click(object sender, EventArgs e)
        {
                Reporte form = new Reporte();
                form.Show();
                form.CargarPedido(int.Parse(this.Grid.SelectedRows[0].Cells["Codigo"].Value.ToString()));
                this.Close();
        }
        
    }
}
