using Core.DataAccess;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> 
        where TEntity : class, IEntity, new()
        where TContext: DbContext, new()
    {
        public void BaseOperations(TEntity entity, EntityState state)
        {
            using (TContext context = new TContext())
            {
                var handledEntity = context.Entry(entity);
                handledEntity.State = state;
                context.SaveChanges();
            }
        }
        public void Add(TEntity entity)
        {
            BaseOperations(entity, EntityState.Added);
        }

        public void Delete(TEntity entity)
        {
            BaseOperations(entity, EntityState.Deleted);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : 
                    context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            BaseOperations(entity, EntityState.Modified);
        }
    }
}
