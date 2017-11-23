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
        public virtual DbSet<Usuarios> usuario { get; set; }
        public List<DetalleDiscos> Detalle;


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Discos>()
                  .HasMany<DetalleDiscos>(df => df.discos)
                  .WithMany(p => p.disco)
                  .Map(dfp =>
                  {
                      dfp.MapLeftKey("Cancion");
                      dfp.MapRightKey("Duaracio");
                      dfp.ToTable("DetalleDisco");
                  });
        }
    }
}
