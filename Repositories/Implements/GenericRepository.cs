using JukeboxApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JukeboxApp.Repositories.Implements
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly JukeboxContext _jukeboxContext;

        public GenericRepository(JukeboxContext jukeboxContext)
        {
            _jukeboxContext = jukeboxContext;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TEntity>> GetAll()
        {

            return _jukeboxContext.Set<TEntity>().ToList();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _jukeboxContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            await _jukeboxContext.Set<TEntity>().AddAsync(entity);
            await _jukeboxContext.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            await _jukeboxContext.Set<TEntity>().AddAsync(entity);
            await _jukeboxContext.SaveChangesAsync();

            return entity;
        }
    }
}
