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
    public partial class Cuotas : Form
    {
        public municipalidad EntMunicipalidad { get; set; }
        public Cuotas()
        {
            InitializeComponent();
        }
        Formulario.EstadoForm estado;

        private void Proveedor_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = $"Cuotas de: {EntMunicipalidad.nombre}";
            ActualizarGrilla();
            dateTimePicker1.CustomFormat = "MMM yyyy";
            CargarPermisos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validador.VeficarForm(this))
            {
                Datos.cuota item = new Datos.cuota
                {
                    fecha = dateTimePicker1.Value,
                    importe = decimal.Parse(txtImporte.Controls[0].Text),
                    municipalidad = EntMunicipalidad,
                };

                switch (estado)
                {
                    case Formulario.EstadoForm.SinDatos:
                        break;
                    case Formulario.EstadoForm.Seleccionado:
                        break;
                    case Formulario.EstadoForm.Nuevo:
                        if(!BLL.CuotaService.VerificarCuotasCreada(item))
                        {
                            BLL.CuotaService.Guardar(item);
                            ActualizarGrilla();
                            Reporte form = new Reporte();
                            form.Show();
                            form.CargarVolante(item.id);
                        }
                        break;
                    case Formulario.EstadoForm.Modificado:
                        if (MessageBox.Show("¿Desea realizar la modificación?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            item.id = int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString());
                            BLL.CuotaService.Modificar(item);
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
            Grid.DataSource = BLL.CuotaService.Listar(EntMunicipalidad.id);
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
            this.txtImporte.Controls[0].Text = Grid.SelectedRows[0].Cells["Importe"].Value.ToString();
            this.dateTimePicker1.Value =  Convert.ToDateTime(Grid.SelectedRows[0].Cells["Fecha"].Value.ToString());
        }


        private void BorrarDatos()
        {
            this.txtImporte.Controls[0].Text = EntMunicipalidad.monto.ToString();
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

        private void btnVolante_Click(object sender, EventArgs e)
        {
            int cuota = int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString());
            Reporte form = new Reporte();
            form.Show();
            form.CargarVolante(cuota);
        }
        public void CargarPermisos()
        {
            Session session = Session.GetInstance();
            if (session.usuario.perfil_id == 2)
            {
                btnModificar.Visible = false;
                btnEliminar.Visible = false;
            }
        }
    }
}
