using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleDiscos
    {
        [Key]
        public int DetalleDiscoID  { get; set; }
        public int DiscoId { get; set; }
        public string Cancion { get; set; }
        public string DuraciondelaCancion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreador { get; set; }
    }
}
