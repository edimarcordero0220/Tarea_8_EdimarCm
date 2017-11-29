using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        List<TEntity> Lista(Expression<Func<TEntity, bool>> criterioBusqueda);
    }
}
