using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using DAL;
using BLL;

namespace SistemaDeVentasDiscografico.Registros
{
    public partial class rDiscos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.FechaTextBox.Text = string.Format("{0:G}", DateTime.Now);
            this.FechacreacionTextBox.Text = string.Format("{0:G}", DateTime.Now);
        }


        Validar v = new Validar();
        public void LlenarClase(Discos d)
        {
            d.NombreDisco = NombreTextBox.Text;
            d.Productor = ProductorTextBox.Text;
            d.SelloDiscografico = SelloTextBox.Text;
            d.Artista = ArtistaTextBox.Text;
            d.FechaCreacion = Convert.ToDateTime(FechaTextBox.Text);
            d.FechaLanzamiento = Convert.ToDateTime(FechacreacionTextBox.Text);
            d.UsuarioCreador = UsuariosDropDownList.Text;
        }

        public void Limpiar()
        {
            NombreTextBox.Text = "";
            SelloTextBox.Text = "";
            ProductorTextBox.Text = "";
            NombreTextBox.Text = "";
            ArtistaTextBox.Text = "";
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (NombreTextBox.Text == "" || ArtistaTextBox.Text == "" || ProductorTextBox.Text == "" || SelloTextBox.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar Los Campos');</script>");
            }
            else
            {
                Entidades.Discos discos = new Entidades.Discos();
                LlenarClase(discos);
                DiscoBLL.Insertar(discos);
                Limpiar();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Realizado satisfactoriamente');</script>");
            }
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

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void UsuariosDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}