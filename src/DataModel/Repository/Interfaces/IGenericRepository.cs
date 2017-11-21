using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataModel.Repository.Interfaces
{
    public interface IGenericRepository<T>
    {

        T GetById(int id);

        IQueryable<T> GetAll();

        void Edit(T entity);

        void Insert(T entity);

        void Delete(T entity);

        IQueryable<T> FetchAll(Expression<Func<T, bool>> exp);

    }
}
