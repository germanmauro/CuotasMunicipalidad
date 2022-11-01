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
    public partial class ReporteEgresos : Form
    {
        public ReporteEgresos()
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

            this.cmbProveedor.DataSource = BLL.ProveedorService.ListarCombo(true);
            this.cmbBanco.Items.Add(new Datos.proveedor { id = 0, nombre = "Todos" });
            this.cmbProveedor.DisplayMember = "nombre";
            this.cmbProveedor.ValueMember = "id";

            this.cmbBanco.Items.Add(new Datos.banco { id = 0, nombre = "Todos" });
            this.cmbBanco.DataSource = BLL.BancoService.ListarCombo(true);
            this.cmbBanco.DisplayMember = "nombre";
            this.cmbBanco.ValueMember = "id";

            this.cmbFormaPago.Items.Add("Todos");
            this.cmbFormaPago.DataSource = Tipos.FormaPago(true);
        }

        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (hasta.Value.Date >= desde.Value.Date)
            {
                Reporte form = new Reporte();
                form.Show();
                form.CargaCompras(int.Parse(cmbProveedor.SelectedValue.ToString()), int.Parse(cmbBanco.SelectedValue.ToString()), cmbFormaPago.SelectedValue.ToString(), desde.Value, hasta.Value);
            }
            else
            {
                MessageBox.Show("La fecha desde debe ser menor o igual a la fecha hasta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
