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
    public class FacturaBLL
    {
        public static void Insertar(Facturas f)
        {
            try
            {
                SistemaDb db = new SistemaDb();
                db.factura.Add(f);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static List<Facturas> GetLista()
        {
            List<Facturas> lista = new List<Facturas>();
            SistemaDb db = new SistemaDb();
            lista = db.factura.ToList();
            return lista;

        }

        public static void Eliminar(int v)
        {
            SistemaDb db = new SistemaDb();
            Facturas cl = db.factura.Find(v);

            db.factura.Remove(cl);
            db.SaveChanges();
        }
        public static Facturas Buscar(int Id)
        {
            SistemaDb db = new SistemaDb();
            return db.factura.Find(Id);
        }
        public static List<Facturas> GetId(int facturaid)
        {
            List<Facturas> lista = new List<Facturas>();
            SistemaDb db = new SistemaDb();
            lista = db.factura.Where(p => p.FacturaId == facturaid).ToList();
            return lista;
        }
        public static List<Entidades.Facturas> GetList(Expression<Func<Entidades.Facturas, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<Facturas>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }
        public static List<Facturas> GetListTodo()
        {
            List<Facturas> lista = null;
            using (var conn = new Repositorio<Facturas>())
            {
                lista = conn.GetListTodo().ToList();
            }

            return lista;
        }

    }
}
