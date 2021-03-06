﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using System.Linq.Expressions;

namespace BLL
{
    public class DiscoBLL
    {
        public List<DetalleDiscos> Detalle;

        public static void Insertar(Discos d)
        {
            try
            {
                SistemaDb db = new SistemaDb();
                db.disco.Add(d);
                db.SaveChanges();
                db.Dispose();
               // return false;
            }
            catch (Exception ex)
            {
              //  return true;
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

        public static List<Entidades.Discos> GetList(Expression<Func<Entidades.Discos, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<Discos>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }
        public static List<Discos> GetListTodo()
        {
            List<Discos> lista = null;
            using (var conn = new Repositorio<Discos>())
            {
                lista = conn.GetListTodo().ToList();
            }

            return lista;
        }

    }
}

