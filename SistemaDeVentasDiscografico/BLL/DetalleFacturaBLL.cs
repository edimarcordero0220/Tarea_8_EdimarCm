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
    public class DetalleFacturaBLL
    {
        public static void Insertar(DetalleFactura df)
        {
            try
            {
                SistemaDb db = new SistemaDb();
                db.detallefactura.Add(df);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static List<DetalleFactura> GetLista()
        {
            List<DetalleFactura> lista = new List<DetalleFactura>();
            SistemaDb db = new SistemaDb();
            lista = db.detallefactura.ToList();
            return lista;

        }
        public static void Eliminar(int v)
        {
            SistemaDb db = new SistemaDb();
            DetalleFactura cl = db.detallefactura.Find(v);

            db.detallefactura.Remove(cl);
            db.SaveChanges();
        }
        public static DetalleFactura Buscar(int Id)
        {
            SistemaDb db = new SistemaDb();
            return db.detallefactura.Find(Id);
        }
        public static List<DetalleFactura> GetId(int detallefacturaid)
        {
            List<DetalleFactura> lista = new List<DetalleFactura>();
            SistemaDb db = new SistemaDb();
            lista = db.detallefactura.Where(p => p.DetalleFacturaId == detallefacturaid).ToList();
            return lista;
        }
        public static List<Entidades.DetalleFactura> GetList(Expression<Func<Entidades.DetalleFactura, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<DetalleFactura>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }
    }
}
