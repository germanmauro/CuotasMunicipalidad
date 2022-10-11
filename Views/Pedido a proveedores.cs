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
    public partial class Pedido_a_proveedores : Form
    {
        //List<Entidades.ItemPedido> list;
        public Pedido_a_proveedores()
        {
            InitializeComponent();
        }

        Formulario.EstadoForm estado;
        private void Pedido_a_proveedores_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            if (Grid.SelectedRows.Count > 0)
            {
                estado = Formulario.EstadoForm.Seleccionado;
                ActualizarVista();
            }
        }

        #region Metodos
        private void ActualizarGrilla()
        {
            //Grid.DataSource = BLL.ProveedorBLL.Listar();
            //estado = Formulario.EstadoForm.SinDatos;
            //grpDetalle.Enabled = false;
            //ActualizarVista();
        }

        private void ActualizarVista()
        {
            switch (estado)
            {
                case Formulario.EstadoForm.SinDatos:
                    btnPedido.Enabled = false;
                    break;
                case Formulario.EstadoForm.Seleccionado:
                    btnPedido.Enabled = true;
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

        private void btnPedido_Click(object sender, EventArgs e)
        {
            //list = BLL.PedidoBLL.CrearLista(int.Parse(Grid.SelectedRows[0].Cells["Codigo"].Value.ToString()));
            //GridDetalle.DataSource = list;
            if(GridDetalle.Rows.Count>0)
            {
                grpDetalle.Enabled = true;
                btnPedir.Enabled = true;
            }
            else
            {
                grpDetalle.Enabled = false;
                btnPedir.Enabled = false;
            }
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            //Entidades.Pedido ped = new Entidades.Pedido
            //{
            //    Estado = Entidades.Pedido.EstadoPedido.Realizado,
            //    Fecha = DateTime.Today,
            //    Proveedor = new Entidades.Proveedor(int.Parse(Grid.SelectedRows[0].Cells["Codigo"].Value.ToString())),
            //    ListaDetalle = list
            //};
            //int codPed = BLL.PedidoBLL.GenerarPedido(ped);
            //if (codPed>0)
            //{
            //    Reporte form = new Reporte();
            //    form.Show();
            //    form.CargarPedido(codPed);
            //    this.Close();
            //}
        }
    }
}
