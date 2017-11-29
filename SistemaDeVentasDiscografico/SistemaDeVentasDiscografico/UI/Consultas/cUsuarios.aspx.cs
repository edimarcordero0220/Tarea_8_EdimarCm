using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace SistemaDeVentasDiscografico.Consulta
{
    public partial class cUsuarios : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {            
     
        }

        public static List<Usuarios> Listas { get; set; }
        private void BuscarSelecCombo()
        {
            if (DropDownList.SelectedIndex == 0)
            {
                int Busqueda = Utilidades.TOINT(FlitrarTextbox.Text);
                Listas = UsuarioBLL.GetList(p => p.UsuarioId == Busqueda);
                ConsultaUsuarioGridView.DataSource = Listas;
                ConsultaUsuarioGridView.DataBind();
            }
            else if (DropDownList.SelectedIndex == 1)
            {
                if (FlitrarTextbox.Text == "")
                {
                    base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
                }
                else
                {
                    Listas = UsuarioBLL.GetList( p => p.Nombre == FlitrarTextbox.Text);
                    ConsultaUsuarioGridView.DataSource = Listas;
                    ConsultaUsuarioGridView.DataBind();
                }
            }
            ConsultaUsuarioGridView.DataSource = Listas;
            ConsultaUsuarioGridView.DataBind();
        }








        protected void filtrarButton_Click(object sender, EventArgs e)
        {
           

        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            BuscarSelecCombo();
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Reportes/ReportesUsuariosWebForm.aspx");
        }
    }
} 