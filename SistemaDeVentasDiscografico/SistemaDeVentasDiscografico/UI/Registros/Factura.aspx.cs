using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using BLL;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace SistemaDeVentasDiscografico.UI
{
    public partial class Factura : System.Web.UI.Page
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



                dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Id Disco"), new DataColumn("Nombre"), new DataColumn("Precio") });
                ViewState["Facturas"] = dt;
            }
        }

        public void CalcularMonto()
        {
            decimal Precio = 0m;
            
            decimal Total = 0;

            if (FacturaGridView.Rows.Count > 0)
            {
                foreach (GridViewRow precio in FacturaGridView.Rows)
                {
                    Precio += Convert.ToDecimal(precio.Cells[2].Text);
                    //PrecioTextBox.Text = Precio.ToString();
                }
            }

            Total = Precio;
            TotalTextBox.Text = Total.ToString();
        }


        private void CargarData()
        {
           /* DetalleDiscos d = new DetalleDiscos();
            SqlConnection conetar = new SqlConnection("Data Source=DESKTOP-19EANE5;Initial Catalog=SistemaDb;Integrated Security=True");
            SqlDataAdapter s = new SqlDataAdapter("select Cancion, DuraciondelaCancion from DetalleDiscos", conetar);
            //DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            s.Fill(dt);
            this.DetalleDiscoGridView.DataSource = (dt);
            DetalleDiscoGridView.DataBind();*/


        }

        public void BuscarFactura(Facturas f)
        {
            IDTextBox.Text = f.FacturaId.ToString();

            f.FechaVenta = Convert.ToDateTime(FechaTextBox.Text);
            f.Nombre = ClienteTextBox.Text;
            NombreTextBox.Text = f.Nombre.ToString();

            CargarData();



        }
        public void BuscarDiscos(Discos d)
        {
            IdDiscoTextBox.Text = d.DiscoId.ToString();
            NombreDiscoTextBox.Text = d.NombreDisco;

        }

        public void BuscarClientes(Clientes c)
        {
            ClienteTextBox.Text = c.ClienteId.ToString();
            NombreTextBox.Text = c.NombreCliente;

        }
        public void LimpiarTexbox()
        {
            IdDiscoTextBox.Text = "";
            NombreDiscoTextBox.Text = "";
            PrecioTextBox.Text = "";
        }
        public void LlenarClase(Facturas c)
        {

            c.FacturaId = Utilidades.TOINT(IDTextBox.Text);
            c.ClienteId = Utilidades.TOINT(ClienteTextBox.Text);
            c.FechaVenta = Convert.ToDateTime(FechaTextBox.Text);
            c.Nombre = NombreTextBox.Text;
            c.Total = Convert.ToInt32(TotalTextBox.Text);
            //PrecioTextBox.Text = c.Precio.ToString();
            //c.NombreDisco = DescripcionDiscotextBox.Text;
            // c.Precio = Convert.ToDecimal(PreciotextBox.Text);

            //c.Precio = Utilidades.TOINT(PreciotextBox.Text);

            
            foreach (GridViewRow dr in FacturaGridView.Rows)
            {
                c.NombreDisco = dr.Cells[1].Text;
             c.Precio=  Convert.ToInt32( dr.Cells[2].Text);
                
             
            }

        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {

        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Entidades.Facturas fac = new Entidades.Facturas();
            LlenarClase(fac);
            FacturaBLL.Insertar(fac);
            Limpiar();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Proceso Completado');</script>");
          
        }

        protected void BindGrid()
        {
            FacturaGridView.DataSource = (DataTable)ViewState["Facturas"];
            FacturaGridView.DataBind();
            CalcularMonto();
        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            if (IdDiscoTextBox.Text =="" || NombreDiscoTextBox.Text=="" || PrecioTextBox.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar los sigte campos: id disco, Nombre del disco y el precio');</script>");
            }
            else
            {
                DataTable dt = (DataTable)ViewState["Facturas"];
                dt.Rows.Add(IdDiscoTextBox.Text, NombreDiscoTextBox.Text, PrecioTextBox.Text);
                ViewState["Facturas"] = dt;
                LimpiarTexbox();
                this.BindGrid();
            }
          
        }

        protected void BuscardiscoButton_Click(object sender, EventArgs e)
        {
            BuscarDiscos(DiscoBLL.Buscar(v.String(IdDiscoTextBox.Text)));

        }

        protected void BuscarclienteButton_Click(object sender, EventArgs e)
        {
            BuscarClientes(ClientesBLL.Buscar(v.String(ClienteTextBox.Text)));
        }

        public void Limpiar()
        {
            IdDiscoTextBox.Text = "";
            IDTextBox.Text = "";
            NombreDiscoTextBox.Text = "";
            NombreTextBox.Text = "";
            ClienteTextBox.Text = "";
            PrecioTextBox.Text = "";
        }
        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar el Campo Id');</script>");
            }
            else
            {
                FacturaBLL.Eliminar(v.String(IDTextBox.Text));
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Proceso Completado');</script>");
            }
        
    }
    }
}