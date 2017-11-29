using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using BLL;

namespace SistemaDeVentasDiscografico.UI.Consultas
{
    public partial class cFacturas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static List<Facturas> Listas { get; set; }
        private void BuscarSelecCombo()
        {



            if (DropDownList.SelectedIndex == 0)
            {
                int Busqueda = Utilidades.TOINT(FlitrarTextbox.Text);
                Listas = FacturaBLL.GetList(p => p.FacturaId == Busqueda);
                ConsultaFacturaGridView.DataSource = Listas;
                ConsultaFacturaGridView.DataBind();
            }
            else if (DropDownList.SelectedIndex == 1)
            {
                if (FlitrarTextbox.Text == "")
                {
                    base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
                }
                else
                {
                    Listas = FacturaBLL.GetList(p => p.Nombre == FlitrarTextbox.Text);
                    ConsultaFacturaGridView.DataSource = Listas;
                    ConsultaFacturaGridView.DataBind();
                }
            }
            if (DropDownList.SelectedIndex == 2)
            {
                int Busqueda = Utilidades.TOINT(FlitrarTextbox.Text);
                Listas = FacturaBLL.GetList(p => p.ClienteId == Busqueda);
                ConsultaFacturaGridView.DataSource = Listas;
                ConsultaFacturaGridView.DataBind();
            }
            else if (DropDownList.SelectedIndex == 3)
            {
                if (FlitrarTextbox.Text == "")
                {
                    base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
                }
                else
                {
                    Listas = FacturaBLL.GetList(p => p.NombreDisco == FlitrarTextbox.Text);
                    ConsultaFacturaGridView.DataSource = Listas;
                    ConsultaFacturaGridView.DataBind();
                }
            }


            ConsultaFacturaGridView.DataSource = Listas;
            ConsultaFacturaGridView.DataBind();
        }

        private bool ValidarBuscar()
        {
            if (FacturaBLL.Buscar(String(FlitrarTextbox.Text)) == null)
            {
                base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe');</script>");
                return false;

            }

            return true;


        }
        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }
        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            BuscarSelecCombo();
            ValidarBuscar();
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            //Response.Redirect("../Reportes/DfReporte.aspx");
        }
    }
}