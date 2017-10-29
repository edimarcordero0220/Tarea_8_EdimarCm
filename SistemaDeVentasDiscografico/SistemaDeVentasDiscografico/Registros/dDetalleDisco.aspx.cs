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
using System.Data.SqlClient;

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
        private void CargarData()
        {
            DetalleDiscos d = new DetalleDiscos();
            SqlConnection conetar = new SqlConnection("Data Source=DESKTOP-19EANE5;Initial Catalog=SistemaDb;Integrated Security=True");
            SqlDataAdapter s = new SqlDataAdapter("select Cancion, DuraciondelaCancion from DetalleDiscos", conetar);
            //DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            s.Fill(dt);
            this.GridView1.DataSource =(dt) ;
            GridView1.DataBind();
         

    }

        public void BuscarDetalle(DetalleDiscos d)
        {
            detalleTextBox.Text = d.DetalleDiscoID.ToString();

            d.FechaCreacion = Convert.ToDateTime(FechaTextBox.Text);
            CargarData();


        }

        public void BuscarDiscos(Discos d)
        {
            IdTextBox.Text = d.DiscoId.ToString();
            NombreTextBox.Text = d.NombreDisco;

        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if(IdTextBox.Text=="")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar El Campo Disco ID');</script>");
            }
            else
            {
                BuscarDiscos(DiscoBLL.Buscar(v.String(IdTextBox.Text)));

            }
            
        }
        protected void BindGrid()
        {
            GridView1.DataSource = (DataTable)ViewState["DetalleDiscos"];
            GridView1.DataBind();
        }

        public void LlenarClase(DetalleDiscos d)
        {
           
            d.FechaCreacion = Convert.ToDateTime(FechaTextBox.Text);
            foreach (GridViewRow dr in GridView1.Rows)
            {
                d.Cancion= dr.Cells[0].Text;
                d.DuraciondelaCancion=dr.Cells[1].Text;
            }




        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            if (CancionTextBox.Text=="" || DuracionTextBox.Text=="")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar el Campo Cancion Y el Campo Duracion');</script>");
            }
            else
            {
                DataTable dt = (DataTable)ViewState["DetalleDiscos"];
                dt.Rows.Add(CancionTextBox.Text, DuracionTextBox.Text);
                ViewState["DetalleDiscos"] = dt;
                this.BindGrid();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Proceso Completado');</script>");

            }
            
           
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text=="" || NombreTextBox.Text=="" || CancionTextBox.Text=="" || DuracionTextBox.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar todos los Campos');</script>");
            }
            else
            {
                Entidades.DetalleDiscos discos = new Entidades.DetalleDiscos();
                LlenarClase(discos);
                DetalleDiscoBLL.Insertar(discos);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Proceso Completado');</script>");
            }
            
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            if (detalleTextBox.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar el campo ID');</script>");
            }
            else
            {
                BuscarDetalle(DetalleDiscoBLL.Buscar(v.String(detalleTextBox.Text)));
                
            }

             


           
            //BuscarDiscos(DiscoBLL.Buscar(v.String(IdTextBox.Text)));

           



        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}