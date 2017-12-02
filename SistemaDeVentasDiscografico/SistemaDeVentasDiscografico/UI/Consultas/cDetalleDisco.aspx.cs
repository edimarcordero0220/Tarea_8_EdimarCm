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
    public partial class cDetalleDisco : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Listas = BLL.DetalleDiscoBLL.GetListTodo();

                ConsultaDetalleDiscoGridView.DataSource = Listas;
                ConsultaDetalleDiscoGridView.DataBind();
            }
        }
        public static List<DetalleDiscos> Listas { get; set; }
        private void BuscarSelecCombo()
        {

            Listas = null;

            if (DropDownList.SelectedIndex == 0)
            {
                Listas = BLL.DetalleDiscoBLL.GetListTodo();

            }


            if (DropDownList.SelectedIndex == 1)
                {
                    int Busqueda = Utilidades.TOINT(FlitrarTextbox.Text);
                    Listas = DetalleDiscoBLL.GetList(p => p.DetalleDiscoID == Busqueda);
                    ConsultaDetalleDiscoGridView.DataSource = Listas;
                    ConsultaDetalleDiscoGridView.DataBind();
                }
                else if (DropDownList.SelectedIndex == 2)
                {
                    if (FlitrarTextbox.Text == "" )
                    {
                        base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
                    }
                    else
                    {
                        Listas = DetalleDiscoBLL.GetList(p => p.Nombre == FlitrarTextbox.Text);
                        ConsultaDetalleDiscoGridView.DataSource = Listas;
                        ConsultaDetalleDiscoGridView.DataBind();
                    }
                }
                if (DropDownList.SelectedIndex == 3)
                {
                    int Busqueda = Utilidades.TOINT(FlitrarTextbox.Text);
                    Listas = DetalleDiscoBLL.GetList(p => p.DiscoId == Busqueda);
                    ConsultaDetalleDiscoGridView.DataSource = Listas;
                    ConsultaDetalleDiscoGridView.DataBind();
            }
            if (DropDownList.SelectedIndex == 4)
            {
                if (DesdeTextBox.Text != "" && HastaTextBox.Text != "")
                {
                    DateTime desde = Convert.ToDateTime(DesdeTextBox.Text);
                    DateTime hasta = Convert.ToDateTime(HastaTextBox.Text);
                    if (desde <= hasta)
                    {
                        Listas = BLL.DetalleDiscoBLL.GetList(p => p.FechaCreacion >= desde && p.FechaCreacion <= hasta);

                    }
                    else
                    {

                        Listas = null;
                    }
                }
                else
                {

                    Listas = null;
                }
            }


            ConsultaDetalleDiscoGridView.DataSource = Listas;
                ConsultaDetalleDiscoGridView.DataBind();
            }
        private bool ValidarBuscar()
        {
            if (DetalleDiscoBLL.Buscar(String(FlitrarTextbox.Text)) == null)
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
            Response.Redirect("../Reportes/DetalleDiscoReporte.aspx");
        }
    }
}