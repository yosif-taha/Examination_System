using Examination_System.Contracts;
using Examination_System.Data;
using Examination_System.Models;
using Examination_System.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Concurrent;

namespace Examination_System.UnitofWork
{
    public class UnitOfWork(Context _context) : IUnitOfWork
    {
        private ConcurrentDictionary<string, object> _Repository = new ConcurrentDictionary<string, object>();

       

        public IGenericRepository<TKey, TEntity> GetRepository<TKey, TEntity>() where TEntity : BaseModel<TKey>
        {
            return (IGenericRepository<TKey, TEntity>)_Repository.GetOrAdd(typeof(TEntity).Name, new GenericRepository<TKey, TEntity>(_context));
        }

        public async Task<int> SaveChangeAsync()
        {
           return await _context.SaveChangesAsync();
        }
    }
}
