using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Datos;

namespace StockMyG
{
    public partial class Banco : Form
    {
        public Banco()
        {
            InitializeComponent();
        }
        Formulario.EstadoForm estado;
        private void banco_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            CargaCombo();
            CargarPermisos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validador.VeficarForm(this))
            {
                banco ent = new banco
                {
                    nombre = txtNombre.Controls[0].Text,
                    direccion = direccion_txt.Controls[0].Text,
                    telefono = txtTelefono.Controls[0].Text,
                    tipo_cuenta = cmbTipoCuenta.SelectedItem.ToString(),
                    numero_cuenta = txtNroCuenta.Controls[0].Text
                };

                switch (estado)
                {
                    case Formulario.EstadoForm.SinDatos:
                        break;
                    case Formulario.EstadoForm.Seleccionado:
                        break;
                    case Formulario.EstadoForm.Nuevo:
                        BLL.BancoService.Guardar(ent);
                        break;
                    case Formulario.EstadoForm.Modificado:
                        ent.id = int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString());
                        BLL.BancoService.Modificar(ent);
                        break;
                    default:
                        break;
                }
                ActualizarGrilla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realizar la eliminación?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                banco ent = new banco
                {
                    id = int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString())
                };
                BLL.BancoService.Eliminar(ent);

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
        private void ActualizarGrilla(string filtro = "")
        {
            Grid.DataSource = BLL.BancoService.Listar(filtro);
            estado = Formulario.EstadoForm.SinDatos;
            ActualizarVista();
        }

        private void CargaCombo()
        {
            this.cmbTipoCuenta.DataSource = Tipos.TipoCuenta();
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
            this.txtNombre.Controls[0].Text = Grid.SelectedRows[0].Cells["nombre"].Value.ToString();
            this.direccion_txt.Controls[0].Text = Grid.SelectedRows[0].Cells["direccion"].Value.ToString();
            this.txtTelefono.Controls[0].Text = Grid.SelectedRows[0].Cells["telefono"].Value.ToString();
            this.txtNroCuenta.Controls[0].Text = Grid.SelectedRows[0].Cells["numero_cuenta"].Value.ToString();
            this.cmbTipoCuenta.SelectedIndex = this.cmbTipoCuenta.FindStringExact(Grid.SelectedRows[0].Cells["tipo_cuenta"].Value.ToString());
        }

        private void BorrarDatos()
        {
            this.txtNombre.Controls[0].Text = "";
            this.direccion_txt.Controls[0].Text = "";
            this.txtTelefono.Controls[0].Text = "";
            this.txtNroCuenta.Controls[0].Text = "";
        }
        #endregion

        private void Banco_KeyDown(object sender, KeyEventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(txtFiltro.Text);
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
