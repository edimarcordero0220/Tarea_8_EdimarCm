using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using BLL;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data;

namespace SistemaDeVentasDiscografico.Registros
{
    public partial class dDetalleDisco : System.Web.UI.Page
    {
        System.Data.DataTable table;
        System.Data.DataRow row;
        Validar v = new Validar();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.FechaTextBox.Text = string.Format("{0:G}", DateTime.Now);
            if (IsPostBack == false)
            {
                

                dt.Columns.AddRange(new DataColumn[2] { new DataColumn("Cancion"), new DataColumn("Duracion") });
                ViewState["DetalleDiscos"] = dt;
            }




        }
        public void BuscarDetalle(DetalleDiscos d)
        {
            IdTextBox.Text = d.DiscoId.ToString();
            NombreTextBox.Text = d.Nombre;
            d.FechaCreacion=Convert.ToDateTime(FechaTextBox.Text);
            foreach (GridViewRow dr in GridView1.Rows)
            {

                d.Cancion = dr.Cells[0].Text;
                d.DuraciondelaCancion = dr.Cells[1].Text;
            }



        }

        public void BuscarDiscos(Discos d)
        {
            IdTextBox.Text = d.DiscoId.ToString();
            NombreTextBox.Text = d.NombreDisco;

        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            BuscarDiscos(DiscoBLL.Buscar(v.String(IdTextBox.Text)));
        }
        protected void BindGrid()
        {
            GridView1.DataSource = (DataTable)ViewState["DetalleDiscos"];
            GridView1.DataBind();
        }

        public void LlenarClase(DetalleDiscos d)
        {
            d.DiscoId = Convert.ToInt32(IdTextBox.Text);
            d.Nombre = NombreTextBox.Text;
            d.FechaCreacion = Convert.ToDateTime(FechaTextBox.Text);
            foreach (GridViewRow dr in GridView1.Rows)
            {
                d.Cancion= dr.Cells[0].Text;
                d.DuraciondelaCancion=dr.Cells[1].Text;
            }




        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)ViewState["DetalleDiscos"];
            dt.Rows.Add(CancionTextBox.Text, DuracionTextBox.Text);
            ViewState["DetalleDiscos"] = dt;
            this.BindGrid();
           
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Entidades.DetalleDiscos discos = new Entidades.DetalleDiscos();
            LlenarClase(discos);
            DetalleDiscoBLL.Insertar(discos);
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            BuscarDetalle(DetalleDiscoBLL.Buscar(v.String(IdTextBox.Text)));
        }
    }
}