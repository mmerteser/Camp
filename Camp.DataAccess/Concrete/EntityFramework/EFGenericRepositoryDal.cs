using Camp.DataAccess.Abstract;
using Camp.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Camp.DataAccess.Concrete.EntityFramework
{
    public class EFGenericRepositoryDal<T> : IEntityRepository<T>
        where T : class,IEntity,new()
    {
        public void Add(T entity)
        {
            // IDisposable pattern iplementation of c#
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<T>().SingleOrDefault(filter);
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null ? context.Set<T>().ToList(): context.Set<T>().Where(filter).ToList();
            }
        }

        public void Update(T entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
