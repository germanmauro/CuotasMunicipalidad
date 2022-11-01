using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;


namespace StockMyG
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            
        }

        public void CargarVolante(int cuota)
        {
            ReportDataSource datasource = new ReportDataSource
            {
                Name = "DataSet",
                Value = BLL.CuotaService.ReporteVolante(cuota)
            };

            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "MecanEasy.Volante.rdlc";
            reportViewer1.LocalReport.ReportPath = "Volante.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);

            reportViewer1.Refresh();
            reportViewer1.RefreshReport();
            reportViewer1.ZoomMode = ZoomMode.FullPage;
        }
        public void CargarRecibo(int cuota)
        {
            ReportDataSource datasource = new ReportDataSource
            {
                Name = "DataSet",
                Value = BLL.CuotaService.ReporteRecibo(cuota),
            };
            
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "MecanEasy.Recibo.rdlc";
            reportViewer1.LocalReport.ReportPath = "Recibo.rdlc";
            reportViewer1.LocalReport.DisplayName = "Recibo" + DateTime.Now.ToString();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);

            reportViewer1.Refresh();
            reportViewer1.RefreshReport();
            reportViewer1.ZoomMode = ZoomMode.FullPage;
        }

        public void CargaMovimientos(int? municipalidad, DateTime? desde = null, DateTime? hasta = null)
        {
            ReportDataSource datasource = new ReportDataSource
            {
                Name = "DataSet",
                Value = BLL.IngresoService.ReporteIngresos(municipalidad, desde, hasta)
            };

            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "MecanEasy.Movimientos.rdlc";
            reportViewer1.LocalReport.ReportPath = "Movimientos.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);

            reportViewer1.RefreshReport();
            reportViewer1.ZoomMode = ZoomMode.FullPage;
        }
        public void CargaCompras(int proveedor,int banco, string forma_pago, DateTime desde, DateTime hasta)
        {
            ReportDataSource datasource = new ReportDataSource
            {
                Name = "DataSet",
                Value = BLL.CompraService.ReporteEgresos(proveedor, banco, forma_pago, desde, hasta)
            };

            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "MecanEasy.Egresos.rdlc";
            reportViewer1.LocalReport.ReportPath = "Egresos.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);

            reportViewer1.RefreshReport();
            reportViewer1.ZoomMode = ZoomMode.FullPage;
        }

        public void CargaInventario()
        {
            ReportDataSource datasource = new ReportDataSource
            {
                Name = "DataSet",
                Value = BLL.InventarioService.Listar()
            };

            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "MecanEasy.Inventario.rdlc";
            reportViewer1.LocalReport.ReportPath = "Inventario.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);

            reportViewer1.Refresh();
            reportViewer1.RefreshReport();
            reportViewer1.ZoomMode = ZoomMode.FullPage;
        }

    }
}
