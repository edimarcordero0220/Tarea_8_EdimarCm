using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string CedulaCliente { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificador { get; set; }

        public static Clientes Buscar(int v)
        {
            throw new NotImplementedException();
        }
    }
}
