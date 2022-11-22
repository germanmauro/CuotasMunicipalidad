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
    public partial class Oficina : Form
    {
        public Oficina()
        {
            InitializeComponent();
        }
        Formulario.EstadoForm estado;
        private void form_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            CargarPermisos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validador.VeficarForm(this))
            {
                oficina ent = new oficina
                {
                    nombre = txtNombre.Controls[0].Text,
                };

                switch (estado)
                {
                    case Formulario.EstadoForm.SinDatos:
                        break;
                    case Formulario.EstadoForm.Seleccionado:
                        break;
                    case Formulario.EstadoForm.Nuevo:
                        BLL.OficinaService.Guardar(ent);
                        break;
                    case Formulario.EstadoForm.Modificado:
                        ent.id = int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString());
                        BLL.OficinaService.Modificar(ent);
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
                oficina ent = new oficina
                {
                    id = int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString())
                };
                BLL.OficinaService.Eliminar(ent);

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
            Grid.DataSource = BLL.OficinaService.Listar();
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
            this.txtNombre.Controls[0].Text = Grid.SelectedRows[0].Cells["nombre"].Value.ToString();
        }

        private void BorrarDatos()
        {
            this.txtNombre.Controls[0].Text = "";
        }
        #endregion

        private void Oficina_KeyDown(object sender, KeyEventArgs e)
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
