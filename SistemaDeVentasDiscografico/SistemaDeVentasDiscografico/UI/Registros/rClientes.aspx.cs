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
    public partial class rClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.FechaTextBox.Text = string.Format("{0:G}", DateTime.Now);
        }
        Validar v = new Validar();
        public void LlenarClase(Clientes c)
        {
            c.NombreCliente = NombreTextBox.Text;
            c.ApellidoCliente = ApellidoTextBox.Text;
            c.DireccionCliente = DireccionTextBox.Text;
            c.CedulaCliente = CedulaTextBox.Text;
            c.FechaCreacion = Convert.ToDateTime(FechaTextBox.Text);
            c.UsuarioModificador = UsuarioDropDownList.Text;
        }
        public void Buscar(Clientes c)
        {
            IdTextBox.Text = c.ClienteId.ToString();
            NombreTextBox.Text = c.NombreCliente;
            ApellidoTextBox.Text = c.ApellidoCliente;
            DireccionTextBox.Text = c.DireccionCliente;
            CedulaTextBox.Text = c.CedulaCliente;


        }
        public void Limpiar()
        {
            IdTextBox.Text = "";
            NombreTextBox.Text = "";
            ApellidoTextBox.Text = "";
            DireccionTextBox.Text = "";
            CedulaTextBox.Text = "";
            
        }
        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (NombreTextBox.Text == "" || ApellidoTextBox.Text == "" || DireccionTextBox.Text == "" || CedulaTextBox.Text == "" || UsuarioDropDownList.Text=="")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar Los Campos');</script>");
            }
            else
            {
                Entidades.Clientes cliente = new Entidades.Clientes();
                LlenarClase(cliente);
                ClientesBLL.Insertar(cliente);
                Limpiar();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Realizado satisfactoriamente');</script>");
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
                ClientesBLL.Eliminar(v.String(IdTextBox.Text));
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Proceso Completado');</script>");
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar El Campo Disco ID');</script>");
            }
            else
            {
                Buscar(ClientesBLL.Buscar(v.String(IdTextBox.Text)));

            }
        }
    }
}