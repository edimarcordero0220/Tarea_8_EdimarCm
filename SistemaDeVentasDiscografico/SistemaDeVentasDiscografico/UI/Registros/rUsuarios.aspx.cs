using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using BLL;
using DAL;


namespace SistemaDeVentasDiscografico.Registros
{
    public partial class rUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        Validar v = new Validar();
        public void LlenarClase(Usuarios u)
        {
            u.Nombre = NombreTextBox.Text;
            u.Contrasena = ContrasenaTextBox.Text;
            u.ConfirmarContrasena = ConfirmarTextBox.Text;
           

        }
        public void Limpiar()
        {
            IdTextBox.Text = "";
            NombreTextBox.Text = "";
            ConfirmarTextBox.Text = "";
            ContrasenaTextBox.Text = "";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (NombreTextBox.Text == "" || ContrasenaTextBox.Text == "" || ConfirmarTextBox.Text == "" )
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar Los Campos');</script>");
            }
            else
            {
                Entidades.Usuarios usu = new Entidades.Usuarios();
                LlenarClase(usu);
                UsuarioBLL.Insertar(usu);
                Limpiar();
                //Utilidades.ShowToastr(this, "No se ha Registrado Usuario con este ID", "Error", "warning");
                // Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Realizado satisfactoriamente');</script>");

                Utilidades.ShowToastr(this, "Registro Procesado", "Exito", "success");
            }

        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar el Campo Id');</script>");
            }
            else
            {
                DiscoBLL.Eliminar(v.String(IdTextBox.Text));
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Proceso Completado');</script>");
            }
        }
        public void BuscarUsuario(Entidades.Usuarios u)
        {
            if (UsuarioBLL.Buscar(String(IdTextBox.Text)) == null)
            {
                base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe');</script>");


            }
            else
            {

                NombreTextBox.Text = u.Nombre;
                ContrasenaTextBox.Text = u.Contrasena;
                ConfirmarTextBox.Text = u.ConfirmarContrasena;

            }
        }

        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }
        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar el Campo Id');</script>");
            }
            else
            {
                BuscarUsuario(UsuarioBLL.Buscar(v.String(IdTextBox.Text)));
                
            }
           


        }
    }
}