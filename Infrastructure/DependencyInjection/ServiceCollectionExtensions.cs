using ad_work_demo_net.Application.Abstractions.Data;
using ad_work_demo_net.Application.Abstractions.Repositories;
using ad_work_demo_net.Infrastructure.Data;
using ad_work_demo_net.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ad_work_demo_net.Infrastructure.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAdventureWorksDataAccess(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("AdventureWorks")
            ?? throw new InvalidOperationException("AdventureWorks connection string is not configured.");

        services.AddDbContext<AdventureWorksDbContext>(options =>
        {
            options.UseSqlServer(connectionString, sqlOptions =>
            {
                sqlOptions.EnableRetryOnFailure();
            });
        });

        services.AddScoped<IAdventureWorksDbContext>(sp => sp.GetRequiredService<AdventureWorksDbContext>());
        services.AddScoped<IUnitOfWork, AdventureWorksUnitOfWork>();
        services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
        services.AddScoped(typeof(IReadRepository<>), typeof(EfRepository<>));

        return services;
    }
}
