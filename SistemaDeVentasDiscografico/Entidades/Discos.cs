using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public  class Discos
    {
        [Key]
        public int DiscoId  { get; set; }
        public string NombreDisco { get; set; }
        public string  UsuarioCreador{ get; set; }
        public string Artista { get; set; }
        public string Productor { get; set; }
        public string SelloDiscografico { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int DetalleId { get; set; }
    }
}
