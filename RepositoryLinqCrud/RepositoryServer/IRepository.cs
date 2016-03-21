using System;
using System.Linq;
using System.Linq.Expressions;

namespace RepositoryServer
{
    public interface IRepository<T>
    {
        void Insert(T entity);
        void Delete(T entity);
        IQueryable<T> SearchFoRQueryable(Expression<Func<T, bool>> predicatexExpression);
        IQueryable<T> GetAllQueryable();
        T GetById(int id);
    }
}