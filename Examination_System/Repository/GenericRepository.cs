using Examination_System.Contracts;
using Examination_System.Data;
using Examination_System.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Examination_System.Repository
{
    public class GenericRepository<TKey, TEntity> (Context _context) : IGenericRepository<TKey, TEntity> where TEntity : BaseModel<TKey>
    {
        public async Task<IQueryable<TEntity>> GetAllAsync()
        {
            var result = _context.Set<TEntity>();
            return result;
        }

        public async Task<TEntity?> GetByIdAsync(TKey key)
        {
            return await _context.Set<TEntity>().FindAsync(key);
        }

        public async Task AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public void Update(TEntity entity)
        {
            _context.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
        }

    }
}
