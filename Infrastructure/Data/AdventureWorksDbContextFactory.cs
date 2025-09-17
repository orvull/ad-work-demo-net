using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ad_work_demo_net.Infrastructure.Data;

public class AdventureWorksDbContextFactory : IDesignTimeDbContextFactory<AdventureWorksDbContext>
{
    public AdventureWorksDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .AddJsonFile("appsettings.Development.json", optional: true)
            .AddEnvironmentVariables()
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<AdventureWorksDbContext>();
        var connectionString = configuration.GetConnectionString("AdventureWorks")
            ?? throw new InvalidOperationException("AdventureWorks connection string is not configured.");

        optionsBuilder.UseSqlServer(connectionString);

        return new AdventureWorksDbContext(optionsBuilder.Options);
    }
}
