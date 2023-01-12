using CleanArchitectureDotnet.Application.Contracts.BaseConstracts;
using CleanArchitectureDotnet.Persistence;
using CleanArchitectureDotnet.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureDotnet.Presentation.Extensions
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddDbContext<BaseDbContext>(options =>
            {

            });

            services.AddScoped<IBaseRepository, BaseRepository>();
            return services;
        }
    }
}
