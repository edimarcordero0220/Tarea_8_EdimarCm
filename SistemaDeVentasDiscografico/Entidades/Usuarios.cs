using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string ConfirmarContrasena { get; set; }

        public static List<Entidades.Usuarios> Lista { get; set; }
        public Usuarios(int usuarioid, string nombre)
        {
           
                this.UsuarioId = usuarioid;
                this.Nombre = nombre;
                

            
        }

        public Usuarios()
        {
        }
    }
}
