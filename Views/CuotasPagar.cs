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
    public partial class CuotasPagar : Form
    {
        public CuotasPagar()
        {
            InitializeComponent();
        }
        Formulario.EstadoForm estado;

        private void Proveedor_Load(object sender, EventArgs e)
        {
            Grid.Columns["Fecha"].DisplayIndex = 0;
            ActualizarGrilla();
            CargaCombo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validador.VeficarForm(this))
            {
                Datos.cuota item = new Datos.cuota
                {
                    fecha_pago = DateTime.Today,
                    importe_abonado = decimal.Parse(txtImporte.Controls[0].Text),
                    banco_id = ((Datos.banco)cmbBanco.SelectedItem).id,
                    forma_pago = cmbFormaPago.SelectedItem.ToString(),
                };

                switch (estado)
                {
                    case Formulario.EstadoForm.Modificado:
                        if (MessageBox.Show("¿Desea registrar el pago de la cuota?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            item.id = int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString());
                            item.intereses = Decimal.Parse(Grid.SelectedRows[0].Cells["Intereses"].Value.ToString());
                            BLL.CuotaService.Pagar(item);
                            ActualizarGrilla();
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el pago?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Datos.cuota ent = new Datos.cuota
                {
                    id = int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString())
                };
                BLL.CuotaService.Eliminar(ent);

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
            Grid.DataSource = BLL.CuotaService.ListarAPagar();
            estado = Formulario.EstadoForm.SinDatos;
            ActualizarVista();
        }

        private void ActualizarVista()
        {
            switch (estado)
            {
                case Formulario.EstadoForm.SinDatos:
                    btnModificar.Enabled = false;
                    btnVolante.Enabled = false;
                    groupInformacion.Enabled = false;
                    Grid.ClearSelection();
                    BorrarDatos();
                    break;
                case Formulario.EstadoForm.Seleccionado:
                    groupInformacion.Enabled = false;
                    btnModificar.Enabled = true;
                    btnVolante.Enabled = true;
                    break;
                case Formulario.EstadoForm.Nuevo:
                    groupInformacion.Enabled = true;
                    Grid.ClearSelection();
                    btnModificar.Enabled = false;
                    btnVolante.Enabled = false;
                    BorrarDatos();
                    break;
                case Formulario.EstadoForm.Modificado:
                    groupInformacion.Enabled = true;
                    CargarDatos();
                    break;
                default:
                    break;
            }
        }

        private void CargarDatos()
        {
            this.txtImporte.Controls[0].Text = (Convert.ToDecimal(Grid.SelectedRows[0].Cells["Importe"].Value) + Convert.ToDecimal(Grid.SelectedRows[0].Cells["Intereses"].Value)).ToString();
        }

        private void BorrarDatos()
        {
            this.txtImporte.Controls[0].Text = "0";
        }

        #endregion

        private void Producto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F3:
                    if (btnModificar.Enabled)
                    {
                        btnModificar_Click(null, null);
                    }
                    break;
                case Keys.F4:
                    if (btnVolante.Enabled)
                    {
                        btnVolante_Click(null, null);
                    }
                    break;
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

        private void CargaCombo()
        {
            this.cmbBanco.DataSource = BLL.BancoService.ListarCombo();
            this.cmbBanco.DisplayMember = "nombre";
            this.cmbBanco.ValueMember = "id";

            this.cmbFormaPago.DataSource = Tipos.FormaPago();

        }

        private void btnVolante_Click(object sender, EventArgs e)
        {
            int cuota = int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString());
            Reporte form = new Reporte();
            form.Show();
            form.CargarVolante(cuota);
        }
    }
}
