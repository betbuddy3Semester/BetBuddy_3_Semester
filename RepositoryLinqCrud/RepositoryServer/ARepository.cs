using System;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;

namespace RepositoryServer
{
    public abstract class ARepository : IRepository<T> where T : class, IEntity
    {
        Table<T> 
        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAllQueryable()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> SearchFoRQueryable(Expression<Func<T, bool>> predicatexExpression)
        {
            throw new NotImplementedException();
        }
    }
}