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
    public partial class Ingresos : Form
    {
        public municipalidad EntMunicipalidad { get; set; }
        public Ingresos()
        {
            InitializeComponent();
        }
        Formulario.EstadoForm estado;

        private void Proveedor_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = $"Ingresos de: {EntMunicipalidad.nombre}";
            ActualizarGrilla();
            CargaCombo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validador.VeficarForm(this))
            {
                Datos.ingreso item = new Datos.ingreso
                {
                    descripcion = txtDescripcion.Controls[0].Text,
                    banco_id = ((Datos.banco)cmbBanco.SelectedItem).id,
                    fecha = dateTimePicker1.Value,
                    importe = decimal.Parse(txtImporte.Controls[0].Text),
                    forma_pago = cmbFormaPago.SelectedItem.ToString(),
                    municipalidad_id = EntMunicipalidad.id
                };

                switch (estado)
                {
                    case Formulario.EstadoForm.SinDatos:
                        break;
                    case Formulario.EstadoForm.Seleccionado:
                        break;
                    case Formulario.EstadoForm.Nuevo:
                        BLL.IngresoService.Guardar(item);
                        ActualizarGrilla();
                        break;
                    case Formulario.EstadoForm.Modificado:
                        if (MessageBox.Show("¿Desea realizar la modificación?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            item.id = int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString());
                            BLL.IngresoService.Modificar(item);
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
            if (MessageBox.Show("¿Desea realizar la eliminación?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Datos.inventario ent = new Datos.inventario
                {
                    id = int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString())
                };
                BLL.InventarioService.Eliminar(ent);

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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estado = Formulario.EstadoForm.Nuevo;
            ActualizarVista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estado = Formulario.EstadoForm.Modificado;
            ActualizarVista();
        }

        #region Metodos
        private void ActualizarGrilla()
        {
            Grid.DataSource = BLL.IngresoService.Listar();
            estado = Formulario.EstadoForm.SinDatos;
            ActualizarVista();
        }

        private void ActualizarVista()
        {
            switch (estado)
            {
                case Formulario.EstadoForm.SinDatos:
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    groupInformacion.Enabled = false;
                    Grid.ClearSelection();
                    BorrarDatos();
                    break;
                case Formulario.EstadoForm.Seleccionado:
                    groupInformacion.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                    break;
                case Formulario.EstadoForm.Nuevo:
                    groupInformacion.Enabled = true;
                    Grid.ClearSelection();
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
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
            this.txtDescripcion.Controls[0].Text = Grid.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            this.txtImporte.Controls[0].Text = Grid.SelectedRows[0].Cells["Importe"].Value.ToString();
            this.dateTimePicker1.Value =  Convert.ToDateTime(Grid.SelectedRows[0].Cells["Fecha"].Value.ToString());
            this.cmbFormaPago.SelectedIndex = this.cmbFormaPago.FindStringExact(Grid.SelectedRows[0].Cells["FormaPago"].Value.ToString());
            this.cmbBanco.SelectedIndex = this.cmbBanco.FindStringExact(Grid.SelectedRows[0].Cells["Banco"].Value.ToString());
        }

        private void CargaCombo()
        {
            this.cmbBanco.DataSource = BLL.BancoService.ListarCombo();
            this.cmbBanco.DisplayMember = "nombre";
            this.cmbBanco.ValueMember = "id";

            this.cmbFormaPago.DataSource = Tipos.FormaPago();
           
        }

        private void BorrarDatos()
        {
            this.txtDescripcion.Controls[0].Text = "";
            this.txtImporte.Controls[0].Text = "";
            this.dateTimePicker1.Value = DateTime.Today;

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
                case Keys.F3:
                    if (btnModificar.Enabled)
                    {
                        btnModificar_Click(null, null);
                    }
                    break;
                case Keys.F4:
                    if (btnEliminar.Enabled)
                    {
                        btnEliminar_Click(null, null);
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

    }
}
