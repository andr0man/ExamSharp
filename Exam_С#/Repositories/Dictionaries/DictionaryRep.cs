using Core.Context;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Common;

namespace Repositories.Dictionaries
{
    public class DictionaryRep : Repository<MyDictionary>, IDictionaryRep
    {
        public DictionaryRep(ProjectContext ctx) : base(ctx)
        {
        }

        public async override Task<IEnumerable<MyDictionary>> GetAllAsync()
        {
            return await _ctx.Dictionaries.Include("Words").ToListAsync();
        }

        public virtual async Task<MyDictionary> GetAsync(int id)
        {
            return await _ctx.Dictionaries.Include(x => x.Words).FirstAsync(x => x.Id == id);
        }
    }
}
