using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;


namespace BLL
{
    public class DiscoBLL
    {
        public static void Insertar(Discos d)
        {
            try
            {
                SistemaDb db = new SistemaDb();
                db.disco.Add(d);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public static List<Discos> GetLista()
        {
            List<Discos> lista = new List<Discos>();
            SistemaDb db = new SistemaDb();
            lista = db.disco.ToList();
            return lista;

        }

        public static void Eliminar(int v)
        {
            SistemaDb db = new SistemaDb();
            Discos cl = db.disco.Find(v);

            db.disco.Remove(cl);
            db.SaveChanges();
        }
        public static Discos Buscar(int Id)
        {
            SistemaDb db = new SistemaDb();
            return db.disco.Find(Id);
        }
    }
}
