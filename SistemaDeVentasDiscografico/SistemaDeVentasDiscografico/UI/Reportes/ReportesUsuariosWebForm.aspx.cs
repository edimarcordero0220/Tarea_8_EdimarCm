using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaDeVentasDiscografico.UI.Reportes
{
    public partial class ReportesUsuariosWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportViewerUsuario.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
            ReportViewerUsuario.Reset();

            ReportViewerUsuario.LocalReport.ReportPath = Server.MapPath(@"UsuariosReport.rdlc");
            ReportViewerUsuario.LocalReport.DataSources.Clear();



            ReportViewerUsuario.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSetUsuario", Consulta.cUsuarios
              .Listas));

            ReportViewerUsuario.LocalReport.Refresh();
        }
    }
}