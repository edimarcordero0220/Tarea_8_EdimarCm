using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using System.Linq.Expressions;

namespace BLL
{
    public class DetalleDiscoBLL
    {
        
        public static void Insertar(DetalleDiscos d)
        {
            try
            {
                SistemaDb db = new SistemaDb();
                db.detalla.Add(d);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<DetalleDiscos> Detalle()
        {
            List<DetalleDiscos> lista = new List<DetalleDiscos>();
            SistemaDb db = new SistemaDb();
            lista = db.detalla.ToList();
            return lista;

        }
        public static DetalleDiscos Buscar(int Id)
        {
            SistemaDb db = new SistemaDb();
            return db.detalla.Find(Id);
        }

        public static void Eliminar(int v)
        {
            SistemaDb db = new SistemaDb();
            DetalleDiscos cl = db.detalla.Find(v);

            db.detalla.Remove(cl);
            db.SaveChanges();
        }
        public static List<Entidades.DetalleDiscos> GetList(Expression<Func<Entidades.DetalleDiscos, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<DetalleDiscos>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }
    }
}
