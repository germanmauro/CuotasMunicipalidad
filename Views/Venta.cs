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
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }
        Formulario.EstadoForm estado;
        private void Reparacion_Load(object sender, EventArgs e)
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
            //Grid.DataSource = BLL.ClienteBLL.Listar();
            estado = Formulario.EstadoForm.SinDatos;
            Grid.ClearSelection();
            ActualizarVista();
        }

        private void ActualizarVista()
        {
            switch (estado)
            {
                case Formulario.EstadoForm.SinDatos:
                    btnSiguiente.Enabled = false;
                    Grid.ClearSelection();
                    break;
                case Formulario.EstadoForm.Seleccionado:
                    btnSiguiente.Enabled = true;
                    break;
                case Formulario.EstadoForm.Nuevo:
                    break;
                case Formulario.EstadoForm.Modificado:
                    break;
                default:
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Grid.DataSource = BLL.ClienteBLL.ListarFiltro(this.txtFiltro.Text);
            estado = Formulario.EstadoForm.SinDatos;
            ActualizarVista();
        }

        #endregion

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
                //Venta2 form = new Venta2();
                //Entidades.Cliente cli = new Entidades.Cliente(int.Parse(Grid.SelectedRows[0].Cells["Codigo"].Value.ToString()));
                //cli.RazonSocial = Grid.SelectedRows[0].Cells["Nombre"].Value.ToString();

                //form.Cliente = cli;
                //form.Show();
                //this.Close();
        }
    }
}
