using Core.Context;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Words
{
    public class WordRep : Repository<Word>, IWordRep
    {
        public WordRep(ProjectContext ctx) : base(ctx)
        {
        }
        public async override Task<IEnumerable<Word>> GetAllAsync()
        {
            return await _ctx.Words.Include("Translations").ToListAsync();
        }

        public virtual async Task<Word> GetAsync(int id)
        {
            return await _ctx.Words.Include(x => x.Translations).FirstAsync(x => x.Id == id);
        }
    }
}
