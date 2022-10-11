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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        Formulario.EstadoForm estado;
        private void Productos1_Load(object sender, EventArgs e)
        {
            ActualizarCombo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validador.VeficarForm(this))
            {
                //Entidades.Producto item = new Entidades.Producto(txtNombre.Controls[0].Text, txtDescripcion.Controls[0].Text, ((Entidades.Subcategoria)cmbSubCat.SelectedItem).Codigo, decimal.Parse(txtPrecioCompra.Controls[0].Text), decimal.Parse(txtPrecioVenta.Controls[0].Text), ((Entidades.Marca)cmbMarca.SelectedItem).Codigo);

                switch (estado)
                {
                    case Formulario.EstadoForm.SinDatos:
                        break;
                    case Formulario.EstadoForm.Seleccionado:
                        break;
                    case Formulario.EstadoForm.Nuevo:
                        //BLL.ProductoBLL.Guardar(item);
                        ActualizarGrilla();
                        break;
                    case Formulario.EstadoForm.Modificado:
                        if (MessageBox.Show("¿Desea realizar la modificación?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            //item.Id = int.Parse(Grid.SelectedRows[0].Cells["Id"].Value.ToString());
                            //BLL.ProductoBLL.Modificar(item);
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
                //Entidades.Producto ent = new Entidades.Producto(int.Parse(Grid.SelectedRows[0].Cells["Id"].Value.ToString()));
                //BLL.ProductoBLL.Eliminar(ent);

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
            //Grid.DataSource = BLL.ProductoBLL.Listar(((Entidades.Subcategoria)cmbSubCat.SelectedItem).Codigo.ToString());
            estado = Formulario.EstadoForm.SinDatos;
            ActualizarVista();
        }

        private void ActualizarVista()
        {
            switch (estado)
            {
                case Formulario.EstadoForm.SinDatos:
                    btnEliminar.Enabled = false;
                    btnVariante.Enabled = false;
                    btnModificar.Enabled = false;
                    groupInformacion.Enabled = false;
                    Grid.ClearSelection();
                    BorrarDatos();
                    break;
                case Formulario.EstadoForm.Seleccionado:
                    groupInformacion.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnVariante.Enabled = true;
                    btnModificar.Enabled = true;
                    break;
                case Formulario.EstadoForm.Nuevo:
                    groupInformacion.Enabled = true;
                    Grid.ClearSelection();
                    btnEliminar.Enabled = false;
                    btnVariante.Enabled = false;
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
            this.txtPrecioCompra.Controls[0].Text = Grid.SelectedRows[0].Cells["PrecioCompra"].Value.ToString();
            this.txtPrecioVenta.Controls[0].Text = Grid.SelectedRows[0].Cells["PrecioVenta"].Value.ToString();

            foreach (var item in cmbMarca.Items)
            {
                //if (((Entidades.Marca)item).Nombre == Grid.SelectedRows[0].Cells["Marca"].Value.ToString())
                //{
                //    cmbMarca.SelectedItem = item;
                //    break;
                //}
            }
        }

        private void BorrarDatos()
        {
            this.txtNombre.Controls[0].Text = "";
            this.txtDescripcion.Controls[0].Text = "";
            this.txtPrecioCompra.Controls[0].Text = "";
            this.txtPrecioVenta.Controls[0].Text = "";
        }

        private void ActualizarCombo()
        {

            //Combo Marca
            //this.cmbMarca.DataSource = BLL.MarcaBLL.Listar();
            //this.cmbMarca.DisplayMember = "Nombre";
            //this.cmbMarca.ValueMember = "Codigo";

            //this.CmbCat.DataSource = BLL.CategoriaBLL.Listar();
            //this.CmbCat.DisplayMember = "Nombre";
            //this.CmbCat.ValueMember = "Codigo";
            //if (CmbCat.Items.Count > 0)
            //{
            //    CmbCat.SelectedIndex = 0;
            //    this.cmbSubCat.DataSource = BLL.SubCategoriaBLL.Listar(((Entidades.Categoria)CmbCat.SelectedItem).Codigo.ToString());
            //    this.cmbSubCat.DisplayMember = "Nombre";
            //    this.cmbSubCat.ValueMember = "Codigo";
            //    if (cmbSubCat.Items.Count > 0)
            //    {
            //        cmbSubCat.SelectedIndex = 0;
            //        btnNuevo.Enabled = true;
            //        ActualizarGrilla();
            //    }
            //    else
            //    {
            //        btnNuevo.Enabled = false;
            //    }
            //}
        }
        #endregion

        private void CmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.cmbSubCat.DataSource = BLL.SubCategoriaBLL.Listar(((Entidades.Categoria)CmbCat.SelectedItem).Codigo.ToString());
            if (cmbSubCat.Items.Count > 0)
            {
                cmbSubCat.SelectedIndex = 0;
                btnNuevo.Enabled = true;
                ActualizarGrilla();
            }
            else
            {
                btnNuevo.Enabled = false;
                ActualizarVista();
            }
        }

        private void cmbSubCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

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
                    if (btnVariante.Enabled)
                    {
                        btnVariante_Click(null, null);
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnVariante_Click(object sender, EventArgs e)
        {
            //Formulario de variantes de un producto
            Variante form = new Variante();
            //Entidades.Producto pro = new Entidades.Producto(int.Parse(Grid.SelectedRows[0].Cells["Id"].Value.ToString()))
            {
                //Nombre = Grid.SelectedRows[0].Cells["Nombre"].Value.ToString()
            };
            //form.Prod = pro;
            form.Show();
        }
    }
}
