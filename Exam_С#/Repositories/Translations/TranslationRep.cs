using Core.Context;
using Core.Entities;
using Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Translations
{
    public class TranslationRep : Repository<Translation>, ITranslationRep
    {
        public TranslationRep(ProjectContext ctx) : base(ctx)
        {
        }
    }
}
