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
    public class ClientesBLL
    {
        public static void Insertar(Clientes c)
        {
            try
            {
                SistemaDb db = new SistemaDb();
                db.cliente.Add(c);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static List<Clientes> GetLista()
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaDb db = new SistemaDb();
            lista = db.cliente.ToList();
            return lista;

        }

        public static void Eliminar(int v)
        {
            SistemaDb db = new SistemaDb();
            Clientes cl = db.cliente.Find(v);

            db.cliente.Remove(cl);
            db.SaveChanges();
        }
        public static Clientes Buscar(int Id)
        {
            SistemaDb db = new SistemaDb();
            return db.cliente.Find(Id);
        }
        public static List<Clientes> GetListaNombre(string tmp)
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaDb db = new SistemaDb();
            lista = db.cliente.Where(p => p.NombreCliente == tmp).ToList();
            return lista;
        }
        public static List<Clientes> GetContrasena(string tmp)
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaDb db = new SistemaDb();
            lista = db.cliente.Where(p => p.CedulaCliente == tmp).ToList();
            return lista;
        }

        public static List<Entidades.Clientes> GetList(Expression<Func<Entidades.Clientes, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<Clientes>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }

    }
}
