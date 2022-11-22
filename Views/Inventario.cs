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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }
        Formulario.EstadoForm estado;

        private void Proveedor_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            CargaCombo();
            CargarPermisos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validador.VeficarForm(this))
            {
                Datos.inventario item = new Datos.inventario
                {
                    nombre = txtNombre.Controls[0].Text,
                    oficina_id = ((Datos.oficina)cmbOficina.SelectedItem).id
                };

                switch (estado)
                {
                    case Formulario.EstadoForm.SinDatos:
                        break;
                    case Formulario.EstadoForm.Seleccionado:
                        break;
                    case Formulario.EstadoForm.Nuevo:
                        BLL.InventarioService.Guardar(item);
                        ActualizarGrilla();
                        break;
                    case Formulario.EstadoForm.Modificado:
                        if (MessageBox.Show("¿Desea realizar la modificación?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            item.id = int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString());
                            BLL.InventarioService.Modificar(item);
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

        private void btnFotos_Click(object sender, EventArgs e)
        {
            Fotos form = new Fotos
            {
                Inventario = InventarioService.Obtener(int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString()))
            };
            //form.Parent = this;
            form.Show();
        }

        #region Metodos
        private void ActualizarGrilla(string filtro = "")
        {
            Grid.DataSource = BLL.InventarioService.Listar(filtro);
            estado = Formulario.EstadoForm.SinDatos;
            ActualizarVista();
        }

        private void ActualizarVista()
        {
            switch (estado)
            {
                case Formulario.EstadoForm.SinDatos:
                    btnEliminar.Enabled = false;
                    btnFotos.Enabled = false;
                    btnModificar.Enabled = false;
                    groupInformacion.Enabled = false;
                    Grid.ClearSelection();
                    BorrarDatos();
                    break;
                case Formulario.EstadoForm.Seleccionado:
                    groupInformacion.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnFotos.Enabled = true;
                    btnModificar.Enabled = true;
                    break;
                case Formulario.EstadoForm.Nuevo:
                    groupInformacion.Enabled = true;
                    Grid.ClearSelection();
                    btnEliminar.Enabled = false;
                    btnFotos.Enabled = false;
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
  
            this.cmbOficina.SelectedIndex = this.cmbOficina.FindStringExact(Grid.SelectedRows[0].Cells["Oficina"].Value.ToString());
        }

        private void CargaCombo()
        {
            this.cmbOficina.DataSource = BLL.OficinaService.ListarCombo();
            this.cmbOficina.DisplayMember = "nombre";
            this.cmbOficina.ValueMember = "id";
        }

        private void BorrarDatos()
        {
            this.txtNombre.Controls[0].Text = "";
            //this.cmbOficina.SelectedIndex = 0;
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
                    if (btnFotos.Enabled)
                    {
                        btnFotos_Click(null, null);
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
