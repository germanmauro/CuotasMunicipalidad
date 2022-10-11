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
    public partial class SubCategorias : Form
    {
        public SubCategorias()
        {
            InitializeComponent();
        }
        Formulario.EstadoForm estado;
        private void SubCategorias_Load(object sender, EventArgs e)
        {
            ActualizarCombo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validador.VeficarForm(this))
            {
                //Entidades.Subcategoria item = new Entidades.Subcategoria(txtNombre.Controls[0].Text,txtDescripcion.Controls[0].Text, int.Parse(CmbMarcas.SelectedValue.ToString()));

                //switch (estado)
                //{
                //    case Formulario.EstadoForm.SinDatos:
                //        break;
                //    case Formulario.EstadoForm.Seleccionado:
                //        break;
                //    case Formulario.EstadoForm.Nuevo:
                //        BLL.SubCategoriaBLL.Guardar(item);
                //        ActualizarGrilla();
                //        break;
                //    case Formulario.EstadoForm.Modificado:
                //        if (MessageBox.Show("¿Desea realizar la modificación?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                //        {
                //            item.Codigo = int.Parse(Grid.SelectedRows[0].Cells["Codigo"].Value.ToString());
                //            BLL.SubCategoriaBLL.Modificar(item);
                //            ActualizarGrilla();
                //        }
                //        break;
                //    default:
                //        break;
                //}
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realizar la eliminación?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Entidades.Subcategoria ent = new Entidades.Subcategoria(int.Parse(Grid.SelectedRows[0].Cells["Codigo"].Value.ToString()));
                //BLL.SubCategoriaBLL.Eliminar(ent);

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
            //Grid.DataSource = BLL.SubCategoriaBLL.Listar(((Entidades.Categoria)CmbMarcas.SelectedItem).Codigo.ToString());
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
            this.txtNombre.Controls[0].Text = Grid.SelectedRows[0].Cells["Nombre"].Value.ToString();
            this.txtDescripcion.Controls[0].Text = Grid.SelectedRows[0].Cells["Descripcion"].Value.ToString();
        }

        private void BorrarDatos()
        {
            this.txtNombre.Controls[0].Text = "";
            this.txtDescripcion.Controls[0].Text = "";
        }

        private void ActualizarCombo()
        {
            this.CmbMarcas.DataSource = BLL.CategoriaService.Listar();
            this.CmbMarcas.DisplayMember = "nombre";
            this.CmbMarcas.ValueMember = "id";

            if (CmbMarcas.Items.Count > 0)
            {
                CmbMarcas.SelectedIndex = 0;
                ActualizarGrilla();
            }
            else
            {
                btnNuevo.Enabled = false;
            }
        }
        #endregion

        private void CmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }
}
