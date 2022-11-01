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
    public partial class Municipalidad : Form
    {
        public Municipalidad()
        {
            InitializeComponent();
        }
        Formulario.EstadoForm estado;

        private void Proveedor_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            CargaCombo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validador.VeficarForm(this))
            {
                Datos.municipalidad item = new Datos.municipalidad
                {
                    nombre = txtNombre.Controls[0].Text,
                    direccion = txtDireccion.Controls[0].Text,
                    cuit = txtCUIT.Controls[0].Text,
                    telefono = txtTelefono.Controls[0].Text,
                    mail = txtEmail.Controls[0].Text,
                    condicion_iva = cmbCondicion.SelectedItem.ToString(),
                    monto = Convert.ToDecimal(txtMonto.Controls[0].Text),
                    dia_vencimiento = short.Parse(txtVencimiento.Controls[0].Text),
                    porcentaje_aumento_vencimiento = Convert.ToDecimal(txtVencimiento.Controls[0].Text)
                };

                switch (estado)
                {
                    case Formulario.EstadoForm.SinDatos:
                        break;
                    case Formulario.EstadoForm.Seleccionado:
                        break;
                    case Formulario.EstadoForm.Nuevo:
                        BLL.MunicipalidadService.Guardar(item);
                        ActualizarGrilla();
                        break;
                    case Formulario.EstadoForm.Modificado:
                        if (MessageBox.Show("¿Desea realizar la modificación?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            item.id = int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString());
                            BLL.MunicipalidadService.Modificar(item);
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
                Datos.proveedor ent = new Datos.proveedor
                {
                    id = int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString())
                };
                BLL.ProveedorService.Eliminar(ent);

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
            Grid.DataSource = BLL.MunicipalidadService.Listar();
            estado = Formulario.EstadoForm.SinDatos;
            ActualizarVista();
        }

        private void ActualizarVista()
        {
            switch (estado)
            {
                case Formulario.EstadoForm.SinDatos:
                    btnEliminar.Enabled = false;
                    btnCuotas.Enabled = false;
                    btnIngresos.Enabled = false;
                    btnMovimientos.Enabled = false;
                    btnModificar.Enabled = false;
                    groupInformacion.Enabled = false;
                    Grid.ClearSelection();
                    BorrarDatos();
                    break;
                case Formulario.EstadoForm.Seleccionado:
                    groupInformacion.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnCuotas.Enabled = true;
                    btnIngresos.Enabled = true;
                    btnMovimientos.Enabled = true;
                    btnModificar.Enabled = true;
                    break;
                case Formulario.EstadoForm.Nuevo:
                    groupInformacion.Enabled = true;
                    Grid.ClearSelection();
                    btnEliminar.Enabled = false;
                    btnCuotas.Enabled = false;
                    btnIngresos.Enabled = false;
                    btnMovimientos.Enabled = false;
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
            this.txtNombre.Controls[0].Text = Grid.SelectedRows[0].Cells["Nombre"].Value.ToString();
            this.txtCUIT.Controls[0].Text = Grid.SelectedRows[0].Cells["CUIT"].Value.ToString();
            this.txtDireccion.Controls[0].Text = Grid.SelectedRows[0].Cells["Direccion"].Value.ToString();
            this.txtTelefono.Controls[0].Text = Grid.SelectedRows[0].Cells["Telefono"].Value.ToString();
            this.txtEmail.Controls[0].Text = Grid.SelectedRows[0].Cells["Email"].Value.ToString();
            this.txtMonto.Controls[0].Text = Grid.SelectedRows[0].Cells["MontoCuota"].Value.ToString();
            this.txtVencimiento.Controls[0].Text = Grid.SelectedRows[0].Cells["DiaVencimiento"].Value.ToString();
            this.txtPorcentajeAumento.Controls[0].Text = Grid.SelectedRows[0].Cells["PorcentajeAumento"].Value.ToString();
            this.cmbCondicion.SelectedIndex = this.cmbCondicion.FindStringExact(Grid.SelectedRows[0].Cells["Condicion"].Value.ToString());
        }

        private void CargaCombo()
        {
            this.cmbCondicion.DataSource = Tipos.CondicionesIVA();
        }

        private void BorrarDatos()
        {
            this.txtNombre.Controls[0].Text = "";
            this.txtCUIT.Controls[0].Text = "";
            this.txtTelefono.Controls[0].Text = "";
            this.txtDireccion.Controls[0].Text = "";
            this.txtEmail.Controls[0].Text = "";
            this.txtVencimiento.Controls[0].Text = "";
            this.txtMonto.Controls[0].Text = "";
            this.txtPorcentajeAumento.Controls[0].Text = "";
            this.cmbCondicion.SelectedText = "";
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
                case Keys.F6:
                    if (btnCuotas.Enabled)
                    {
                        btnCuotas_Click(null, null);
                    }
                break;
                case Keys.F7:
                    if (btnIngresos.Enabled)
                    {
                        btnIngresos_Click(null, null);
                    }
                break;
                case Keys.F8:
                    if (btnMovimientos.Enabled)
                    {
                        btnMovimientos_Click(null, null);
                    }
                break;

                default:
                    break;
            }
        }

        private void btnCuotas_Click(object sender, EventArgs e)
        {
            Cuotas form = new Cuotas
            {
                EntMunicipalidad = MunicipalidadService.Obtener(int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString()))
            };
            //form.Parent = this;
            form.Show();
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            Ingresos form = new Ingresos
            {
                EntMunicipalidad = MunicipalidadService.Obtener(int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString()))
            };
            //form.Parent = this;
            form.Show();
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            int cuota = int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString());
            Reporte form = new Reporte();
            form.Show();
            form.CargaMovimientos(cuota);
        }
    }
}
