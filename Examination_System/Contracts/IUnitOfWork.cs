using Examination_System.Models;

namespace Examination_System.Contracts
{
    public interface IUnitOfWork
    {
        IGenericRepository<TKey, TEntity> GetRepository<TKey, TEntity>() where TEntity : BaseModel<TKey>;

        Task<int> SaveChangeAsync();
    }

}
