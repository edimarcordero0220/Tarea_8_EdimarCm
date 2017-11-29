using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaDeVentasDiscografico.UI.Reportes
{
    public partial class FacturaReporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FacturaReportViewer.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
            FacturaReportViewer.Reset();

            FacturaReportViewer.LocalReport.ReportPath = Server.MapPath(@"DfReporte.aspx");
            FacturaReportViewer.LocalReport.DataSources.Clear();



            FacturaReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("FacturaDataSet", Consultas.cFacturas
              .Listas));

            FacturaReportViewer.LocalReport.Refresh();
        }
    }
}