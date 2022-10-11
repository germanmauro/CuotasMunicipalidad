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
    public partial class Talle : Form
    {
        
        public Talle()
        {
            InitializeComponent();
        }
        Formulario.EstadoForm estado;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validador.VeficarForm(this))
            {
                //Entidades.Talle ent = new Entidades.Talle(txtNombre.Controls[0].Text);

                //switch (estado)
                //{
                //    case Formulario.EstadoForm.SinDatos:
                //        break;
                //    case Formulario.EstadoForm.Seleccionado:
                //        break;
                //    case Formulario.EstadoForm.Nuevo:
                //        BLL.TalleBLL.Guardar(ent);
                //        break;
                //    case Formulario.EstadoForm.Modificado:
                //        if (MessageBox.Show("¿Desea realizar la modificación?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                //        {
                //            ent.Codigo = int.Parse(Grid.SelectedRows[0].Cells["Codigo"].Value.ToString());
                //            BLL.TalleBLL.Modificar(ent);
                //        }
                //        break;
                //    default:
                //        break;
                //}
                ActualizarGrilla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realizar la eliminación?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Entidades.Talle ent = new Entidades.Talle(int.Parse(Grid.SelectedRows[0].Cells["Codigo"].Value.ToString()), Grid.SelectedRows[0].Cells["Nombre"].Value.ToString());
                //BLL.TalleBLL.Eliminar(ent);

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
            //Grid.DataSource = BLL.TalleBLL.Listar();
//            Grid.Sort(Grid.Columns["Nombre"],ListSortDirection.Ascending);
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
        }

        private void BorrarDatos()
        {
            this.txtNombre.Controls[0].Text = "";
        }
        #endregion

        private void Color_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }
}
