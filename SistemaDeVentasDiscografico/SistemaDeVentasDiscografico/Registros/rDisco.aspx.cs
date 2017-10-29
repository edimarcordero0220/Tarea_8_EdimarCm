using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using BLL;

namespace SistemaDeVentasDiscografico.Registros
{
    public partial class rDisco : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Fecha1TextBox.Text = string.Format("{0:G}", DateTime.Now);
            this.Fecha2TextBox.Text = string.Format("{0:G}", DateTime.Now);

        }
       
        Validar v = new Validar();
        public void LlenarClase(Discos d)
        {
            d.NombreDisco = NombreTextBox.Text;
            d.Productor = ProductorTextBox.Text;
            d.SelloDiscografico = SelloTextBox.Text;
            d.Artista = ArtistaTextBox.Text;
            d.FechaCreacion = Convert.ToDateTime(Fecha1TextBox.Text);
            d.FechaLanzamiento = Convert.ToDateTime(Fecha2TextBox.Text);

        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (NombreTextBox.Text=="" || ArtistaTextBox.Text=="" || ProductorTextBox.Text==""||SelloTextBox.Text=="")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar Los Campos');</script>");
            }
            else
            {
                Entidades.Discos discos = new Entidades.Discos();
                LlenarClase(discos);
                DiscoBLL.Insertar(discos);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Realizado satisfactoriamente');</script>");
            }
            
            

        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text =="")
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
            NombreTextBox.Text = "";
            SelloTextBox.Text = "";
            ProductorTextBox.Text = "";
            NombreTextBox.Text = "";
            ArtistaTextBox.Text = "";

        }
    }
}