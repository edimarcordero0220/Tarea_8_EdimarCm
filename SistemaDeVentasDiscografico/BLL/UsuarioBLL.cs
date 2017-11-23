using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;


namespace BLL
{
   public  class UsuarioBLL
    {
        public static void Insertar(Usuarios u)
        {
            try
            {
                SistemaDb db = new SistemaDb();
                db.usuario.Add(u);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public static List<Usuarios> GetLista()
        {
            List<Usuarios> lista = new List<Usuarios>();
            SistemaDb db = new SistemaDb();
            lista = db.usuario.ToList();
            return lista;

        }

        public static void Eliminar(int v)
        {
            SistemaDb db = new SistemaDb();
            Usuarios cl = db.usuario.Find(v);

            db.usuario.Remove(cl);
            db.SaveChanges();
        }
        public static Usuarios Buscar(int Id)
        {
            SistemaDb db = new SistemaDb();
            return db.usuario.Find(Id);
        }
        public static List<Usuarios> GetListaNombre(string tmp)
        {
            List<Usuarios> lista = new List<Usuarios>();
            SistemaDb db = new SistemaDb();
            lista = db.usuario.Where(p => p.Nombre == tmp).ToList();
            return lista;
        }
        public static List<Usuarios> GetContrasena(string tmp)
        {
            List<Usuarios> lista = new List<Usuarios>();
            SistemaDb db = new SistemaDb();
            lista = db.usuario.Where(p => p.Contrasena == tmp).ToList();
            return lista;
        }
    }
}
