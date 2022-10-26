using BLL;
using Datos;
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
    public partial class CuotasPagadas : Form
    {
        public CuotasPagadas()
        {
            InitializeComponent();
        }
        Formulario.EstadoForm estado;

        private void Proveedor_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn item in Grid.Columns)
            {
                item.DisplayIndex = item.Index;
            }
            ActualizarGrilla();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el pago?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Datos.cuota ent = new Datos.cuota
                {
                    id = int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString())
                };
                BLL.CuotaService.EliminarPago(ent);

                ActualizarGrilla();
            }
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            if (Grid.SelectedRows.Count > 0)
            {
                estado = Formulario.EstadoForm.Seleccionado;
                ActualizarVista();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estado = Formulario.EstadoForm.Modificado;
            ActualizarVista();
        }

        #region Metodos
        private void ActualizarGrilla()
        {
            Grid.DataSource = BLL.CuotaService.ListarPagas();
            estado = Formulario.EstadoForm.SinDatos;
            ActualizarVista();
        }

        private void ActualizarVista()
        {
            switch (estado)
            {
                case Formulario.EstadoForm.SinDatos:
                    btnEliminar.Enabled = false;
                    btnRecibo.Enabled = false;
                    Grid.ClearSelection();
                    break;
                case Formulario.EstadoForm.Seleccionado:
                    btnEliminar.Enabled = true;
                    btnRecibo.Enabled = true;
                    break;
                case Formulario.EstadoForm.Nuevo:
                    Grid.ClearSelection();
                    btnEliminar.Enabled = false;
                    btnRecibo.Enabled = false;
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
                case Keys.F4:
                    if (btnEliminar.Enabled)
                    {
                        btnEliminar_Click(null, null);
                    }
                    break;
                case Keys.F6:
                    if (btnRecibo.Enabled)
                    {
                        btnRecibo_Click(null, null);
                    }
                    break;
    
                default:
                    break;
            }
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            int cuota = int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString());
            Reporte form = new Reporte();
            form.Show();
            form.CargarRecibo(cuota);
        }
    }
}
