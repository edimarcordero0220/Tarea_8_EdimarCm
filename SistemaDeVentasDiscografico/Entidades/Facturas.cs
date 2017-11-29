using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Facturas
    {
        [Key]
        public int FacturaId { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaVenta { get; set; }
        public string UsuarioModificador { get; set; }
        public string Nombre { get; set; }
        public string NombreDisco { get; set; }
        public int Precio { get; set; }
        public int Total { get; set; }
    }
}
