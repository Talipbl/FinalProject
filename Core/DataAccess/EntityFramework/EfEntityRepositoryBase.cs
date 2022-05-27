using Core.DataAccess;
using Core.Entities;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstracts;
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
        where TContext : DbContext, new()
    {
        public IResult BaseOperation(TEntity entity, EntityState state)
        {
            using (TContext context = new TContext())
            {
                var handledEntity = context.Entry(entity);
                handledEntity.State = state;
                return context.SaveChanges() > 0 ? new Result(true) : new Result(false);
            }
        }
        public IResult Add(TEntity entity)
        {
            return BaseOperation(entity, EntityState.Added);
        }

        public IResult Delete(TEntity entity)
        {
            return BaseOperation(entity, EntityState.Deleted);
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

        public IResult Update(TEntity entity)
        {
            return BaseOperation(entity, EntityState.Modified);
        }
    }
}
