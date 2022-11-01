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
    public partial class InventarioBaja : Form
    {
        public InventarioBaja()
        {
            InitializeComponent();
        }
        Formulario.EstadoForm estado;

        private void Proveedor_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validador.VeficarForm(this))
            {
                Datos.inventario item = new Datos.inventario
                {
                    motivo_baja = txtNombre.Controls[0].Text,
                };

                switch (estado)
                {
                    case Formulario.EstadoForm.SinDatos:
                        break;
                    case Formulario.EstadoForm.Seleccionado:
                        break;
                    case Formulario.EstadoForm.Modificado:
                        if (MessageBox.Show("¿Desea realizar la baja de producto seleccionado?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            item.id = int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString());
                            BLL.InventarioService.Baja(item);
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
            if (MessageBox.Show("¿Desea realizar reestablecer la baja?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Datos.inventario ent = new Datos.inventario
                {
                    id = int.Parse(Grid.SelectedRows[0].Cells["id"].Value.ToString())
                };
                BLL.InventarioService.EliminarBaja(ent);

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
        private void ActualizarGrilla()
        {
            Grid.DataSource = BLL.InventarioService.Listar();
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
                    if(Grid.SelectedRows.Count > 0)
                    {
                        btnEliminar.Enabled = Grid.SelectedRows[0].Cells["FechaBaja"].Value.ToString() != DateTime.MinValue.ToString();
                        btnModificar.Enabled = Grid.SelectedRows[0].Cells["FechaBaja"].Value.ToString() == DateTime.MinValue.ToString();
                    }
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
            this.txtNombre.Controls[0].Text = Grid.SelectedRows[0].Cells["MotivoBaja"].Value.ToString();
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
