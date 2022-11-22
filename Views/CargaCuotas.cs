using BLL;
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
    public partial class CargaCuotas : Form
    {
        public CargaCuotas()
        {
            InitializeComponent();
        }
        Formulario.EstadoForm estado;

        private void Proveedor_Load(object sender, EventArgs e)
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Cuotas form = new Cuotas
            {
                EntMunicipalidad = MunicipalidadService.Obtener(int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString()))
            };
            //form.Parent = this;
            form.Show();
        }

        #region Metodos
        private void ActualizarGrilla(string filtro = "")
        {
            Grid.DataSource = BLL.MunicipalidadService.Listar(filtro);
            estado = Formulario.EstadoForm.SinDatos;
            ActualizarVista();
        }

        private void ActualizarVista()
        {
            switch (estado)
            {
                case Formulario.EstadoForm.SinDatos:
                    Grid.ClearSelection();
                    btnNuevo.Enabled = false;
                    break;
                case Formulario.EstadoForm.Seleccionado:
                    btnNuevo.Enabled = true;
                    break;
                case Formulario.EstadoForm.Nuevo:
                    Grid.ClearSelection();
                    break;
                case Formulario.EstadoForm.Modificado:
                    break;
                default:
                    break;
            }
        }

        #endregion

        private void Producto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    if (btnNuevo.Enabled)
                    {
                        btnNuevo_Click(null, null);
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(txtFiltro.Text);
        }
    }
}
