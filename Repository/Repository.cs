using Repository.DbModels;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public void Add(T entity, CityTransportContext context)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity, CityTransportContext context)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public void Edit(T entity, CityTransportContext context)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate, CityTransportContext context)
        {
            return context.Set<T>().Where(predicate);
        }

        public IQueryable<T> GetAll(CityTransportContext context)
        {
            return context.Set<T>();
        }
    }
}
