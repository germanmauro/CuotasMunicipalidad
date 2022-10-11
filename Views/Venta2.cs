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
    public partial class Venta2 : Form
    {
        //public Entidades.Cliente Cliente { get; set; }
        //Entidades.Venta venta;
        public Venta2()
        {
            InitializeComponent();
        }

        private void Reparacion2_Load(object sender, EventArgs e)
        {
            //lblVehiculo.Text = "Venta del cliente: " + Cliente.RazonSocial;
            //ActualizarCombo();
            //venta = new Entidades.Venta(Cliente);
            //venta.VentaDetalle = new List<Entidades.VentaDetalle>();
            //CargarProductos(true);
        }
        //Eliminar Items
        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 0 && e.RowIndex>-1)
            //{
            //    if (MessageBox.Show("¿Desea Eliminar el Producto de la venta?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        foreach (var item in venta.VentaDetalle)
            //        {
            //            if (item.Variante.ToString() == Grid.Rows[e.RowIndex].Cells["Variante"].Value.ToString())
            //            {
            //                venta.VentaDetalle.Remove(item);
            //                break;
            //            }
            //        }
            //        ActualizarGrilla();
            //    }
            //}
        }

        private void CmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.cmbSubCat.DataSource = BLL.SubCategoriaBLL.Listar(((Entidades.Categoria)this.CmbCat.SelectedItem).Codigo.ToString(),true);
            this.cmbSubCat.DisplayMember = "Nombre";
            this.cmbSubCat.ValueMember = "Codigo";
            if (cmbSubCat.Items.Count > 0)
            {
                cmbSubCat.SelectedIndex = 0;
                //CargarProductos();
            }
        }

        #region Metodos
        private void ActualizarCombo()
        {
            //Combo de Marcas.
            //this.cmbMarca.DataSource = BLL.MarcaBLL.Listar(true);
            //this.cmbMarca.DisplayMember = "Nombre";
            //this.cmbMarca.ValueMember = "Codigo";

            ////Combo de Color.
            //this.cmbColor.DataSource = BLL.ColorBLL.Listar(true);
            //this.cmbColor.DisplayMember = "Nombre";
            //this.cmbColor.ValueMember = "Codigo";

            ////Combo de Marcas.
            //this.cmbTalle.DataSource = BLL.TalleBLL.Listar(true);
            //this.cmbTalle.DisplayMember = "Nombre";
            //this.cmbTalle.ValueMember = "Codigo";

            ////Combo de categorías subcategorías y Productos.
            //this.CmbCat.DataSource = BLL.CategoriaBLL.Listar(true);
            //this.CmbCat.DisplayMember = "Nombre";
            //this.CmbCat.ValueMember = "Codigo";
            //if (CmbCat.Items.Count > 0)
            //{
            //    CmbCat.SelectedIndex = 0;
            //    this.cmbSubCat.DataSource = BLL.SubCategoriaBLL.Listar(((Entidades.Categoria)this.CmbCat.SelectedItem).Codigo.ToString(), true);
            //    this.cmbSubCat.DisplayMember = "Nombre";
            //    this.cmbSubCat.ValueMember = "Codigo";
            //    if (cmbSubCat.Items.Count > 0)
            //    {
            //        cmbSubCat.SelectedIndex = 0;
            //        //CargarProductos();                    
            //    }
            //}

            
        }

        private void cargarCantidad()
        {
            //cmbCantidad.Items.Clear();
            //int cantidad = ((Entidades.VentaDetalle)cmbProducto.SelectedItem).Cantidad;

            //for (int i = 1; i <= cantidad; i++)
            //{
            //    cmbCantidad.Items.Add(i);
            //}
            //cmbCantidad.SelectedIndex = 0;
        }

        private void ActualizarGrilla()
        {
            //    lblTotal.Text = venta.Total.ToString();
            //    this.Grid.DataSource = new List<Entidades.VentaDetalle>();
            //    this.Grid.DataSource = venta.VentaDetalle;
            //    this.Grid.Refresh();
            //    if(this.Grid.Rows.Count>0)
            //    {
            //        btnGuardar.Enabled = true;
            //    }
            //    else
            //    {
            //        btnGuardar.Enabled = false;
            //    }
            //    CargarProductos();
        }

        private void CargarProductos(bool inicio = false)
        {
            //List<Entidades.VentaDetalle> listaFinal = new List<Entidades.VentaDetalle>();
            //List<Entidades.VentaDetalle> lista;
            //if (inicio)
            //{
            //    lista = BLL.ProductoBLL.ListarParaVenta("0", "0", "0","", "0", "0");
            //}
            //else
            //{
            //    lista = BLL.ProductoBLL.ListarParaVenta(((Entidades.Categoria)CmbCat.SelectedItem).Codigo.ToString(), ((Entidades.Subcategoria)cmbSubCat.SelectedItem).Codigo.ToString(), ((Entidades.Marca)cmbMarca.SelectedItem).Codigo.ToString(), txtFiltro.Text, ((Entidades.Talle)cmbTalle.SelectedItem).Codigo.ToString(),((Entidades.Color)cmbColor.SelectedItem).Codigo.ToString());
            //}
            
            //foreach (Entidades.VentaDetalle item in lista)
            //{
            //    //bool esta = false;
            //    foreach (var subprod in venta.VentaDetalle)
            //    {
            //        if (item.Variante == subprod.Variante)
            //        {
            //            item.Cantidad -= subprod.Cantidad;
            //            //esta = true;
            //            break;
            //        }
            //    }
            //    if (item.Cantidad > 0)
            //    {
            //        listaFinal.Add(item);
            //    }
            //}
            //this.cmbProducto.DataSource = listaFinal;
            //this.cmbProducto.DisplayMember = "NombreCompleto";
            //this.cmbProducto.ValueMember = "Codigo";

            //if (cmbProducto.Items.Count > 0)
            //{
            //    cmbProducto.SelectedIndex = 0;
            //    cargarCantidad();
            //    btnAgregar.Enabled = true;
            //    cmbProducto.Enabled = true;

            //}
            //else
            //{
            //    cmbProducto.Enabled = false;
            //    cmbProducto.SelectedText = "";
            //    cmbCantidad.Items.Clear();
            //    cmbCantidad.SelectedText = "";
            //    //cmbRepuesto.Items.Clear();
            //    MessageBox.Show("No hay Productos con Stock en esa categoría", "Confirmación");
            //    btnAgregar.Enabled = false;
            //}
        }

        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Entidades.VentaDetalle item = (Entidades.VentaDetalle)cmbProducto.SelectedItem;
            //item.Cantidad = int.Parse(cmbCantidad.SelectedItem.ToString());
            //bool esta = false;
            //foreach (Entidades.VentaDetalle prod in venta.VentaDetalle)
            //{
            //    if(prod.Variante == item.Variante)
            //    {
            //        prod.Cantidad += item.Cantidad;
            //        esta = true;
            //        break;
            //    }
            //}
            //if (!esta)
            //{
            //    venta.VentaDetalle.Add(item);
            //}
            //ActualizarGrilla();

        }

        private void cmbSubCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbSubCat.Items.Count > 0)
            //{
            //    //CargarProductos();

            //    if (cmbRepuesto.Items.Count > 0)
            //    {
            //        cmbRepuesto.SelectedIndex = 0;
            //        cargarCantidad();
            //        btnAgregar.Enabled = true;
            //    }
            //    else
            //    {
            //        MessageBox.Show("No hay Productos con Stock en esa categoría", "Confirmación");
            //        btnAgregar.Enabled = false;
            //    }
            //}
        }

        private void cmbRepuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbProducto.Items.Count > 0 && cmbProducto.SelectedIndex>-1)
            //{
            //    cargarCantidad();
            //}
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea registrar la venta?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //int recibo = BLL.VentaBLL.Guardar(venta);
                //if (recibo > 0)
                //{
                //    Reporte form = new Reporte();
                //    form.Show();
                //    form.CargarRecibo(recibo);
                //    this.Close();
                //}
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }
    }
}
