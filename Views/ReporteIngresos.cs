using Datos;
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
    public partial class ReporteIngresos : Form
    {
        public ReporteIngresos()
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
            //Combo de Municipalidad.
            this.cmbMunicipalidad.DataSource = BLL.MunicipalidadService.ListarCombo();
            this.cmbMunicipalidad.DisplayMember = "nombre";
            this.cmbMunicipalidad.ValueMember = "id";

        }

        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (hasta.Value.Date >= desde.Value.Date)
            {
                Reporte form = new Reporte();
                form.Show();
                form.CargaMovimientos(((municipalidad)cmbMunicipalidad.SelectedItem).id, desde.Value, hasta.Value);
            }
            else
            {
                MessageBox.Show("La fecha desde debe ser menor o igual a la fecha hasta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
