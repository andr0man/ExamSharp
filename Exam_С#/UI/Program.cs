using Microsoft.Extensions.DependencyInjection;
using UI.HttpServices;

namespace UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }

        private static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddScoped(sd => new HttpClient { BaseAddress = new Uri("https://localhost:7083/") });

            //services.AddScoped<DictionaryService>(sp =>
            //{
            //    var httpClient = sp.GetRequiredService<HttpClient>();
            //    return new DictionaryService(httpClient);
            //});

            services.AddTransient<DictionaryService>();

            services.AddScoped<Form1>();

            return services;
        }
    }
}
