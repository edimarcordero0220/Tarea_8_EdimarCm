using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using BLL;
using DAL;

namespace SistemaDeVentasDiscografico.UI.Consultas
{
    public partial class cCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static List<Clientes> Listas { get; set; }
        private void BuscarSelecCombo()
        {
            if (DropDownList.SelectedIndex == 0)
            {
                int Busqueda = Utilidades.TOINT(FlitrarTextbox.Text);
                Listas = ClientesBLL.GetList(p => p.ClienteId == Busqueda);
                ConsultaClienteGridView.DataSource = Listas;
                ConsultaClienteGridView.DataBind();
            }
            else if (DropDownList.SelectedIndex == 1)
            {
                if (FlitrarTextbox.Text == "")
                {
                    base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
                }
                else
                {
                    Listas = ClientesBLL.GetList(p => p.NombreCliente == FlitrarTextbox.Text);
                    ConsultaClienteGridView.DataSource = Listas;
                    ConsultaClienteGridView.DataBind();
                }
            }
            ConsultaClienteGridView.DataSource = Listas;
            ConsultaClienteGridView.DataBind();
        }
        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            BuscarSelecCombo();
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Reportes/ClienteReportes.aspx");
        }
    }
}