using ad_work_demo_net.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false)
    .AddEnvironmentVariables()
    .Build();

var connectionString = configuration.GetConnectionString("AdventureWorks")
    ?? throw new InvalidOperationException("AdventureWorks connection string is not configured.");

var options = new DbContextOptionsBuilder<AdventureWorksDbContext>()
    .UseSqlServer(connectionString, sql => sql.EnableRetryOnFailure())
    .Options;

await using var context = new AdventureWorksDbContext(options);

var peopleCount = await context.Persons.CountAsync();
Console.WriteLine($"AdventureWorks contains {peopleCount} people records.");
