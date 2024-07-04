using Core.Context;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Common
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected ProjectContext _ctx;

        public Repository(ProjectContext ctx)
        {
            _ctx = ctx;
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync() => await _ctx.Set<TEntity>().ToListAsync();

        public virtual async Task CreateAsync(TEntity entity)
        {
            await _ctx.Set<TEntity>().AddAsync(entity);
            await _ctx.SaveChangesAsync();
        }
        public virtual async Task UpdateAsync(TEntity entity)
        {
            _ctx.Set<TEntity>().Update(entity);
            await _ctx.SaveChangesAsync();
        }
        public virtual async Task DeleteAsync(int id)
        {
            _ctx.Set<TEntity>().Remove(await _ctx.Set<TEntity>().FindAsync(id));
            await _ctx.SaveChangesAsync();

        }
        public virtual async Task<TEntity> GetAsync(int id)
        {
            return await _ctx.Set<TEntity>().FindAsync(id);
        }
    }
}
