using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaDeVentasDiscografico.UI.Registros
{
    public partial class DetalleDisco : System.Web.UI.Page
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
            this.DetalleDiscoGridView.DataSource = (dt);
            DetalleDiscoGridView.DataBind();


        }
        public void BuscarDetalle(DetalleDiscos d)
        {
            if (DetalleDiscoBLL.Buscar(String(IdTextBox.Text)) == null)
            {
                base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe');</script>");


            }
            else
            {
                IdTextBox.Text = d.DetalleDiscoID.ToString();

                d.FechaCreacion = Convert.ToDateTime(FechaTextBox.Text);
                d.Nombre = IdDiscoTextBox.Text;
                IdDiscoTextBox.Text = d.DiscoId.ToString();

                CargarData();

            }

        }
        public void BuscarDiscos(Discos d)
        {
            if (DiscoBLL.Buscar(String(IdDiscoTextBox.Text)) == null)
            {
                base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe');</script>");


            }
            else
            {
                IdTextBox.Text = d.DiscoId.ToString();
                NombreTextBox.Text = d.NombreDisco;
            }
        }
        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == "" || NombreTextBox.Text == "" || cancionTextBox.Text == "" || DuracionTextBox.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar todos los Campos');</script>");
            }
            else
            {
                Entidades.DetalleDiscos discos = new Entidades.DetalleDiscos();
                LlenarClase(discos);
                DetalleDiscoBLL.Insertar(discos);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Proceso Completado');</script>");
                Limpiar();
            }
        }

        protected void BuscarDiscoButton_Click(object sender, EventArgs e)
        {
            if (IdDiscoTextBox.Text == "" )
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar El Campo Disco ID');</script>");
            }
            else
            {

                BuscarDiscos(DiscoBLL.Buscar(v.String(IdDiscoTextBox.Text)));
                

            }
        }
        protected void BindGrid()
        {
            DetalleDiscoGridView.DataSource = (DataTable)ViewState["DetalleDiscos"];
            DetalleDiscoGridView.DataBind();
        }
        public void LlenarClase(DetalleDiscos d)
        {

            //DetalleDiscos d = new DetalleDiscos();

            d.FechaCreacion = Convert.ToDateTime(FechaTextBox.Text);
             foreach (GridViewRow dr in DetalleDiscoGridView.Rows)
             {
                 d.Cancion= dr.Cells[0].Text;
                 d.DuraciondelaCancion=dr.Cells[1].Text;
             }
           /* foreach (GridViewRow dr in DetalleDiscoGridView.Rows)
            {
                Discos p = new Discos();
                p.AgregarDetalle(d.Cancion = dr.Cells[0].Text, d.DuraciondelaCancion = dr.Cells[1].Text);
            }*/

        }

        public void Limpiar()
        {
            IdTextBox.Text = "";
            IdDiscoTextBox.Text = "";
            NombreTextBox.Text = "";
            cancionTextBox.Text = "";
            DuracionTextBox.Text = "";

        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            if (cancionTextBox.Text == "" || DuracionTextBox.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar el Campo Cancion Y el Campo Duracion');</script>");
            }
            else
            {
                DataTable dt = (DataTable)ViewState["DetalleDiscos"];
                dt.Rows.Add(cancionTextBox.Text, DuracionTextBox.Text);
                ViewState["DetalleDiscos"] = dt;
                this.BindGrid();
            


            }
        }
  
        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == "" )
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar el campo ID');</script>");
             
                
            }
            else
            {
                BuscarDetalle(DetalleDiscoBLL.Buscar(v.String(IdTextBox.Text)));
                
            }
        }
        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
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
                DetalleDiscoBLL.Eliminar(v.String(IdTextBox.Text));
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Proceso Completado');</script>");
            }
        }
    }
}