using OnlineMarket.Domain.Commons;
using System.Linq.Expressions;

namespace OnlineMarket.DataAccess.IRepositories
{
    public interface IGenericRepository<TEntity> where TEntity : Auditable
    {
        public ValueTask<TEntity> InsertAsync(TEntity entity);
        public ValueTask<TEntity> UpdateAsync(TEntity entity);
        public ValueTask<bool> DeleteAsync(Expression<Func<TEntity, bool>> expression);
        public ValueTask<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression);
        public IQueryable<TEntity> GetAllAsync();
        public ValueTask SaveAsync();
    }
}
