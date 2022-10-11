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
    public partial class Variante : Form
    {
        //public Entidades.Producto Prod { get; set; }
        public Variante()
        {
            InitializeComponent();
        }
        Formulario.EstadoForm estado;
        private void Vehículo_Load(object sender, EventArgs e)
        {
            //lblCliente.Text = "Variantes del Producto: " + Prod.Nombre;
            ActualizarGrilla();
            ActualizarCombo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validador.VeficarForm(this))
            {
                //int color = ((Entidades.Color)cmbColor.SelectedItem).Codigo;
                //int talle = ((Entidades.Talle)cmbTalle.SelectedItem).Codigo;
                //Entidades.Variante item = new Entidades.Variante(txtCodigo.Controls[0].Text, this.Prod.Id, color, talle, int.Parse(txtCantidad.Controls[0].Text), int.Parse(txtMinimo.Controls[0].Text), int.Parse(txtMaximo.Controls[0].Text));

                //switch (estado)
                //{
                //    case Formulario.EstadoForm.SinDatos:
                //        break;
                //    case Formulario.EstadoForm.Seleccionado:
                //        break;
                //    case Formulario.EstadoForm.Nuevo:
                //        BLL.VarianteBLL.Guardar(item);
                //        ActualizarGrilla();
                //        break;
                //    case Formulario.EstadoForm.Modificado:
                //        if (MessageBox.Show("¿Desea realizar la modificación?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                //        {
                //            item.Id = int.Parse(Grid.SelectedRows[0].Cells["Id"].Value.ToString());
                //            BLL.VarianteBLL.Modificar(item);
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
                //Entidades.Variante ent = new Entidades.Variante(int.Parse(Grid.SelectedRows[0].Cells["Id"].Value.ToString()));
                //BLL.VarianteBLL.Eliminar(ent);

                //ActualizarGrilla();
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
            //Grid.DataSource = BLL.VarianteBLL.Listar(Prod.Id);
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
            this.txtCantidad.Controls[0].Text = Grid.SelectedRows[0].Cells["Cantidad"].Value.ToString();
            this.txtMaximo.Controls[0].Text = Grid.SelectedRows[0].Cells["Maximo"].Value.ToString();
            this.txtMinimo.Controls[0].Text = Grid.SelectedRows[0].Cells["Minimo"].Value.ToString();
            this.txtCodigo.Controls[0].Text = Grid.SelectedRows[0].Cells["Codigo"].Value.ToString();
            foreach (var item in cmbColor.Items)
            {
                //if(((Entidades.Color)item).Codigo == int.Parse(Grid.SelectedRows[0].Cells["Color"].Value.ToString()))
                //{
                //    cmbColor.SelectedItem = item;
                //    break;
                //}
            }
            foreach (var item in cmbTalle.Items)
            {
                //if (((Entidades.Talle)item).Codigo == int.Parse(Grid.SelectedRows[0].Cells["Talle"].Value.ToString()))
                //{
                //    cmbTalle.SelectedItem = item;
                //    break;
                //}
            }
 
        }

        private void BorrarDatos()
        {
            this.txtCantidad.Controls[0].Text = "";
            this.txtMaximo.Controls[0].Text = "";
            this.txtMinimo.Controls[0].Text = "";
            this.txtCodigo.Controls[0].Text = "";
        }

        private void ActualizarCombo()
        {
            //Combo Color
            //this.cmbColor.DataSource = BLL.ColorBLL.Listar();
            //this.cmbColor.DisplayMember = "Nombre";
            //this.cmbColor.ValueMember = "Codigo";
            //if (cmbColor.Items.Count > 0)
            //{
            //    cmbColor.SelectedIndex = 0;
            //}
            ////Combo Talle
            //this.cmbTalle.DataSource = BLL.TalleBLL.Listar();
            //this.cmbTalle.DisplayMember = "Nombre";
            //this.cmbTalle.ValueMember = "Codigo";
            //if (cmbTalle.Items.Count > 0)
            //{
            //    cmbTalle.SelectedIndex = 0;
            //}

        }
        #endregion

        private void Variante_KeyDown(object sender, KeyEventArgs e)
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
