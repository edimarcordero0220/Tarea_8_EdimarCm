using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaDeVentasDiscografico.UI.Reportes
{
    public partial class DiscosReportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DiscosReportViewer.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
            DiscosReportViewer.Reset();

            DiscosReportViewer.LocalReport.ReportPath = Server.MapPath(@"Discos.rdlc");
            DiscosReportViewer.LocalReport.DataSources.Clear();



            DiscosReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSet1", Consultas.cDiscos
              .Listas));

            DiscosReportViewer.LocalReport.Refresh();

        }
    }
}