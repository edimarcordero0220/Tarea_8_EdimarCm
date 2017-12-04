using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Discos
    {
        [Key]
        public int DiscoId { get; set; }
        public string NombreDisco { get; set; }
        public string UsuarioCreador { get; set; }
        public string Artista { get; set; }
        public string Productor { get; set; }
        public string SelloDiscografico { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int DetalleId { get; set; }

        //public virtual List<Facturas> factura { get; set; }
        public virtual List<DetalleDiscos> discos { get; set; }
        public Discos()
        {
          //  this.factura = new List<Entidades.Facturas>();
            this.discos = new List<DetalleDiscos>();
        }
        public List<DetalleDiscos> Detalle;
        public void AgregarDetalle(string Cancion, string DuraciondelaCancion)
        {
            this.Detalle.Add(new DetalleDiscos(Cancion, DuraciondelaCancion));
        }
        public Discos(int iddisco, string nombredisco)
        {
            this.DiscoId = iddisco;
            this.NombreDisco = nombredisco;
          //  this.factura = new List<Entidades.Facturas>();
        }

        

    }
}