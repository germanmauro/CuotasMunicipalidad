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
    public partial class ReporteProductos : Form
    {
        public ReporteProductos()
        {
            InitializeComponent();
        }

        private void ReporteVehiculo_Load(object sender, EventArgs e)
        {
            ActualizarCombo();
        }
        
        #region Metodos
        private void ActualizarCombo()
        {
            //Combo de Marcas.
            //this.cmbMarca.DataSource = BLL.MarcaBLL.Listar(true);
            this.cmbMarca.DisplayMember = "Nombre";
            this.cmbMarca.ValueMember = "Codigo";

            //Combo de Color.
            //this.cmbColor.DataSource = BLL.ColorBLL.Listar(true);
            this.cmbColor.DisplayMember = "Nombre";
            this.cmbColor.ValueMember = "Codigo";

            //Combo de Marcas.
            //this.cmbTalle.DataSource = BLL.TalleBLL.Listar(true);
            this.cmbTalle.DisplayMember = "Nombre";
            this.cmbTalle.ValueMember = "Codigo";

            //Combo de categorías subcategorías y Productos.
            //this.CmbCat.DataSource = BLL.CategoriaBLL.Listar(true);
            this.CmbCat.DisplayMember = "Nombre";
            this.CmbCat.ValueMember = "Codigo";
            if (CmbCat.Items.Count > 0)
            {
                CmbCat.SelectedIndex = 0;
                //this.cmbSubCat.DataSource = BLL.SubCategoriaBLL.Listar(((Entidades.Categoria)this.CmbCat.SelectedItem).Codigo.ToString(), true);
                this.cmbSubCat.DisplayMember = "Nombre";
                this.cmbSubCat.ValueMember = "Codigo";
                if (cmbSubCat.Items.Count > 0)
                {
                    cmbSubCat.SelectedIndex = 0;
                    //CargarProductos();                    
                }
            }
        }

        private void CmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.cmbSubCat.DataSource = BLL.SubCategoriaBLL.Listar(((Entidades.Categoria)this.CmbCat.SelectedItem).Codigo.ToString(), true);
            this.cmbSubCat.DisplayMember = "Nombre";
            this.cmbSubCat.ValueMember = "Codigo";
            if (cmbSubCat.Items.Count > 0)
            {
                cmbSubCat.SelectedIndex = 0;
                //CargarProductos();
            }
        }
        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (hasta.Value.Date >= desde.Value.Date)
            {
                Reporte form = new Reporte();
                form.Show();
                //form.CargaProductos(((Entidades.Categoria)CmbCat.SelectedItem).Codigo.ToString(), ((Entidades.Subcategoria)cmbSubCat.SelectedItem).Codigo.ToString(), ((Entidades.Marca)cmbMarca.SelectedItem).Codigo.ToString(), txtFiltro.Text, ((Entidades.Talle)cmbTalle.SelectedItem).Codigo.ToString(), ((Entidades.Color)cmbColor.SelectedItem).Codigo.ToString(),desde.Text,hasta.Text) ;
            }
            else
            {
                MessageBox.Show("La fecha desde debe ser menor o igual a la fecha hasta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
