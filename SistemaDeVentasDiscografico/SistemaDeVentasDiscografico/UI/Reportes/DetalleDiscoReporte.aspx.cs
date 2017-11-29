using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaDeVentasDiscografico.UI.Reportes
{
    public partial class DetalleDiscoReporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DetalleDiscosReportViewer.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
            DetalleDiscosReportViewer.Reset();

            DetalleDiscosReportViewer.LocalReport.ReportPath = Server.MapPath(@"DetalleDiscoReport.rdlc");
            DetalleDiscosReportViewer.LocalReport.DataSources.Clear();



            DetalleDiscosReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSet1", Consultas.cDetalleDisco
              .Listas));

            DetalleDiscosReportViewer.LocalReport.Refresh();
        }
    }
}