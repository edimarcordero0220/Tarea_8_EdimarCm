using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class SistemaDb : DbContext
    {
        public SistemaDb() : base("name = ConStr")
        {
                
        }
        public virtual DbSet<Discos> disco{ get; set; }
        public virtual DbSet<DetalleDiscos> detalla { get; set; }
    }
}
