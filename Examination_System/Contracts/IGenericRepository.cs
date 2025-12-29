using System.Linq.Expressions;

namespace Examination_System.Contracts
{
    public interface IGenericRepository<TKey, TEntity>
    {
        public Task<IQueryable<TEntity>> GetAllAsync();
        public Task<TEntity?> GetByIdAsync(TKey key);
        public Task AddAsync(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);



    }
}
