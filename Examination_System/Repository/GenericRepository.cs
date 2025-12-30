using AutoMapper.QueryableExtensions;
using Examination_System.Contracts;
using Examination_System.Data;
using Examination_System.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Examination_System.Repository
{
    public class GenericRepository<TKey, TEntity> (Context _context) : IGenericRepository<TKey, TEntity> where TEntity : BaseModel<TKey>
    {
        public IQueryable<TEntity> GetAll()
        {
            var result = _context.Set<TEntity>();
            return result;
        }

        public async Task<TEntity?> GetByIdAsync(TKey key)
        {
           var result = await _context.Set<TEntity>().FindAsync(key);
            return result;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }

        public async Task SoftDeleteAsync(TKey key)
        {
            var entity =await GetByIdAsync(key);
            if (entity != null)
            {
                entity.IsDeleted = true;
               _context.Set<TEntity>().Update(entity);
            }
        }

    }
}
