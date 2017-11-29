using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleFactura
    {
        [Key]
        public int DetalleFacturaId { get; set; }
        public int FacturaId { get; set; }
        public int DiscoId { get; set; }
        public DateTime Fechaventa { get; set; }
        public string UsuarioModificador { get; set; }
    }
}
