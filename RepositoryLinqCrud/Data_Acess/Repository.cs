using System;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using Model_Objects;

namespace Data_Acess
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        protected readonly Table<T> DataTable;

        public Repository(DataContext dataContext)
        {
            DataTable = dataContext.GetTable<T>();
        }

        public Repository()
        {
        }

        public void Insert(T entity)
        {
            DataTable.InsertOnSubmit(entity);
        }

        public void Delete(T entity)
        {
            DataTable.DeleteOnSubmit(entity);
        }

        public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
        {
            return DataTable.Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return DataTable;
        }

        public T GetById(int id)
        {
            return DataTable.Single(e => e.Id.Equals(id));
        }
    }

}