using CityTransport.Repository.DbModels;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace CityTransport.Repository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity, CityTransportContext context);

        void Delete(T entity, CityTransportContext context);

        void Edit(T entity, CityTransportContext context);

        IQueryable<T> Find(Expression<Func<T, bool>> predicate, CityTransportContext context);

        IQueryable<T> GetAll(CityTransportContext context);
    }
}
