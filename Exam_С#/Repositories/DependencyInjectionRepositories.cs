using Microsoft.Extensions.DependencyInjection;
using Repositories.Common;
using Repositories.Dictionaries;

namespace Repositories
{
    public static class DependencyInjectionRepositories
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IDictionaryRep, DictionaryRep>();
        }
    }
}
