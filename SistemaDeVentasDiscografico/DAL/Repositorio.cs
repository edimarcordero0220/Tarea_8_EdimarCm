using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Entidades
{
    public class Repositorio<TEntity> : IRepository <TEntity> where TEntity : class
    {
        SistemaDb Contex = null;

        public Repositorio()
        {
            Contex = new SistemaDb();
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> criterioBusqueda)
        {
            try
            {
                return EntitySet.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
                return new List<TEntity>();
            }
        }
        public List<TEntity> GetListTodo()
        {
            try
            {
                return EntitySet.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private DbSet<TEntity> EntitySet
        {
            get
            {

                return Contex.Set<TEntity>();
            }
        }

        public List<TEntity> Lista(Expression<Func<TEntity, bool>> criterioBusqueda)
        {
            List<TEntity> Result = null;
            try
            {
                Result = EntitySet.Where(criterioBusqueda).ToList();
            }
            catch { }

            return Result;
        }

        public List<TEntity> ListaTodo()
        {
            using (var Conec = new DAL.SistemaDb())
            {
                try
                {
                    return EntitySet.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return null;
        }

        public void Dispose()
        {
            if (Contex != null)
                Contex.Dispose();
        }

    }
}
