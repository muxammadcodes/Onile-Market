using Microsoft.EntityFrameworkCore;
using OnlineMarket.DataAccess.Context;
using OnlineMarket.DataAccess.IRepositories;
using OnlineMarket.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.DataAccess.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Auditable
    {
        private readonly OnlineMarketDbContext dbContext;
        private readonly DbSet<TEntity> dbSet;

        public GenericRepository(OnlineMarketDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<TEntity>();  
        }
        public async ValueTask<TEntity> InsertAsync(TEntity entity)
        {
            var model = await this.dbSet.AddAsync(entity);
            return model.Entity;
        }
        public async ValueTask<bool> DeleteAsync(Expression<Func<TEntity, bool>> expression)
        {
            var entity = await dbSet.FirstOrDefaultAsync(expression);
            if (entity == null)
                return false;

            dbSet.Remove(entity);
            return true;
        }
        public IQueryable<TEntity> GetAllAsync() => dbSet;

        public async ValueTask<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression) =>
            await dbSet.FirstOrDefaultAsync(expression);

        public async ValueTask SaveAsync()
        {
            await this.dbContext.SaveChangesAsync();
        }

        public async ValueTask<TEntity> UpdateAsync(TEntity entity)
        {
            var res = dbSet.Update(entity);
            return res.Entity;
        }
    }
}
