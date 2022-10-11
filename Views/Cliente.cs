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
    public partial class Cliente : Form
    {
        Formulario.EstadoForm estado;
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            CargarComboTipo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validador.VeficarForm(this))
            {
                //Entidades.Cliente ent = new Entidades.Cliente(txtNombre.Controls[0].Text, txtDNI.Controls[0].Text, ((Entidades.Tipo)cmbTipo.SelectedItem).Nombre, txtDireccion.Controls[0].Text, txtTelefono.Controls[0].Text, txtMail.Controls[0].Text);

                switch (estado)
                {
                    case Formulario.EstadoForm.SinDatos:
                        break;
                    case Formulario.EstadoForm.Seleccionado:
                        break;
                    case Formulario.EstadoForm.Nuevo:
                        //BLL.ClienteBLL.Guardar(ent);
                        break;
                    case Formulario.EstadoForm.Modificado:
                        if (MessageBox.Show("¿Desea realizar la modificación?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            //ent.Codigo = int.Parse(Grid.SelectedRows[0].Cells["Codigo"].Value.ToString());
                            //BLL.ClienteBLL.Modificar(ent);
                        }
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
                //Entidades.Cliente ent = new Entidades.Cliente(int.Parse(Grid.SelectedRows[0].Cells["Codigo"].Value.ToString()));
                //BLL.ClienteBLL.Eliminar(ent);

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
            //Grid.DataSource = BLL.ClienteBLL.Listar();
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
            this.txtDNI.Controls[0].Text = Grid.SelectedRows[0].Cells["DNI"].Value.ToString();
            this.txtMail.Controls[0].Text = Grid.SelectedRows[0].Cells["Mail"].Value.ToString();
            this.txtDireccion.Controls[0].Text = Grid.SelectedRows[0].Cells["Direccion"].Value.ToString();
            this.txtTelefono.Controls[0].Text = Grid.SelectedRows[0].Cells["Telefono"].Value.ToString();
            foreach (var item in cmbTipo.Items)
            {
                //if(((Entidades.Tipo)item).Nombre == Grid.SelectedRows[0].Cells["Tipo"].Value.ToString())
                //{
                //    cmbTipo.SelectedItem = item;
                //}
            }
        }

        private void BorrarDatos()
        {
            this.txtNombre.Controls[0].Text = "";
            this.txtDNI.Controls[0].Text = "";
            this.txtMail.Controls[0].Text = "";
            this.txtDireccion.Controls[0].Text = "";
            this.txtTelefono.Controls[0].Text = "";
        }

        private void CargarComboTipo()
        {
            this.cmbTipo.DisplayMember = "Nombre";
            this.cmbTipo.ValueMember = "Codigo";
            //this.cmbTipo.DataSource = BLL.TipoBLL.Lista();
        }
        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Grid.DataSource = BLL.ClienteBLL.ListarFiltro(this.txtFiltro.Text);
            estado = Formulario.EstadoForm.SinDatos;
            ActualizarVista();
        }

    }
}
