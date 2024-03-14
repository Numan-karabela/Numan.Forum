using Application.Repository;
using Azure.Core;
using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Persistance.Repository
{
    public class EfCoreRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : BaseEntity
        where TContext : DbContext
    {
        TContext Context;
         
        public EfCoreRepository(TContext context)
        {
            Context = context;
        }
        public IQueryable<TEntity> Query()
        {
            return Context.Set<TEntity>();
        }

        public async Task<bool> AddAsync(TEntity Entity)
        {
            Context.Entry(Entity).State= EntityState.Added; 
            await Context.SaveChangesAsync();
            return true;

        }

        public async Task<bool> DeleteAsync(TEntity Entity)
        {
            Context.Entry(Entity).State= EntityState.Deleted;
            await Context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteIdAsync(int id)
        {
            Context.Entry(id).State= EntityState.Deleted;
            await Context.SaveChangesAsync();
            return true;
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            return Context.Set<TEntity>().AsNoTracking().SingleOrDefault(filter);
        }


        public async Task<TEntity> GettAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            return await Context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(filter);
        }

     
        public async Task<bool> UpdateAsync(TEntity Entity)
        {
            Context.Entry(Entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();
            
            return true;
        }
        
    }
}
