using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Entidades;
using DAL;

namespace SistemaDeVentasDiscografico
{
    public partial class LoginDelSistema : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public bool ValidarUsuario()
        {
            if (UsuarioBLL.GetListaNombre(NombreTextBox.Text).Count() == 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Usuario No Existe!!');</script>");
                return false;
            }
            return true;
        }

        public bool ValidarContrasena()
        {
            if (UsuarioBLL.GetContrasena(ContrasenaTextBox.Text).Count() == 0)
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Clave invalida!!');</script>");
                return false;
            }
            return true;
        }
        protected void EliminarButton_Click(object sender, EventArgs e)
        {
           


        }

        protected void IniciarButton_Click(object sender, EventArgs e)
        {

            if (NombreTextBox.Text == "" || ContrasenaTextBox.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar ambos Campos!!');</script>");
            }
            else
            {
                if (ValidarUsuario() && ValidarContrasena() == true)
                {

                    Response.Redirect("Default.aspx");




                }
            }
            
           
        }
    }
}