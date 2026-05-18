using Microsoft.Extensions.DependencyInjection;
using OilProduction.Application.Contracts;
using OilProduction.Persistence.Repositories;
using System.Reflection;


namespace OilProduction.Persistence
{
    public static class PersistenceContainer
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services )
        {
           

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IWorkRepository), typeof(WorkRepository));

            //services.AddHandlersFromAssembly(typeof(AssemblyReference).Assembly);

            return services;
        }
    }
}
