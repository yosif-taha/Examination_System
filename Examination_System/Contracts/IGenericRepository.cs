using System.Linq.Expressions;

namespace Examination_System.Contracts
{
    public interface IGenericRepository<TKey, TEntity>
    {
        public IQueryable<TEntity> GetAll();
        public Task<TEntity?> GetByIdAsync(TKey key);
        public Task AddAsync(TEntity entity);
        public void Update(TEntity entity);
        public Task SoftDeleteAsync(TKey key);



    }
}
