using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using DAL;
using BLL;

namespace SistemaDeVentasDiscografico.UI.Consultas
{
    public partial class cDiscos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Listas = BLL.DiscoBLL.GetListTodo();

                ConsultaDiscoGridView.DataSource = Listas;
                ConsultaDiscoGridView.DataBind();
            }
        }
        public static List<Discos> Listas { get; set; }
        private void BuscarSelecCombo()
        {
            if (DropDownList.SelectedIndex == 0)
            {
                int Busqueda = Utilidades.TOINT(FlitrarTextbox.Text);
                Listas = DiscoBLL.GetList(p => p.DiscoId == Busqueda);
                ConsultaDiscoGridView.DataSource = Listas;
                ConsultaDiscoGridView.DataBind();
            }
            else if (DropDownList.SelectedIndex == 1)
            {
                if (FlitrarTextbox.Text == "")
                {
                    base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
                }
                else
                {
                    Listas = DiscoBLL.GetList(p => p.Artista == FlitrarTextbox.Text);
                    ConsultaDiscoGridView.DataSource = Listas;
                    ConsultaDiscoGridView.DataBind();
                }
            }
           

            ConsultaDiscoGridView.DataSource = Listas;
            ConsultaDiscoGridView.DataBind();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            BuscarSelecCombo();
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Reportes/DiscosReportes.aspx");
        }
    }
}