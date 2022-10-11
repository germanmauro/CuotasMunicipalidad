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

        public void CargarRecibo(int recibo)
        {
            ReportDataSource datasource = new ReportDataSource
            {
                Name = "DataSet",
                //Value = BLL.ReciboBLL.ReporteRecibo(recibo)
            };

            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "MecanEasy.Recibo.rdlc";
            reportViewer1.LocalReport.ReportPath = "Recibo.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);

            reportViewer1.Refresh();
            reportViewer1.RefreshReport();
            reportViewer1.ZoomMode = ZoomMode.FullPage;
        }

        public void CargaProductos(string categoria, string subcategoria, string marca, string codigo, string talle, string color, string desde, string hasta)
        {
            ReportDataSource datasource = new ReportDataSource
            {
                Name = "DataSet",
                //Value = BLL.VentaBLL.ReporteProducto(categoria, subcategoria, marca, codigo, talle, color, desde, hasta)
            };

            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "MecanEasy.ReporteProducto.rdlc";
            reportViewer1.LocalReport.ReportPath = "ReporteProducto.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);

            reportViewer1.RefreshReport();
            reportViewer1.ZoomMode = ZoomMode.FullPage;
        }

        public void CargarPedido(int ped)
        {
            ReportDataSource datasource = new ReportDataSource
            {
                Name = "DataSet",
                //Value = BLL.PedidoBLL.ReportePedido(ped)
            };

            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "MecanEasy.Pedido.rdlc";
            reportViewer1.LocalReport.ReportPath = "Pedido.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);

            reportViewer1.RefreshReport();
            reportViewer1.ZoomMode = ZoomMode.FullPage;
        }
    }
}
