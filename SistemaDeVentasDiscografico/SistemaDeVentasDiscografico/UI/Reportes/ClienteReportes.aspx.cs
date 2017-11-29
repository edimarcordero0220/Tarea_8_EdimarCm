using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaDeVentasDiscografico.UI.Reportes
{
    public partial class ClienteReportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClienteReportViewer.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
            ClienteReportViewer.Reset();

            ClienteReportViewer.LocalReport.ReportPath = Server.MapPath(@"ClientesReport.rdlc");
            ClienteReportViewer.LocalReport.DataSources.Clear();



            ClienteReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("ClienteDataSet", Consultas.cCliente
              .Listas));

            ClienteReportViewer.LocalReport.Refresh();
        }
    }
}