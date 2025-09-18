using ad_work_demo_net.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ad_work_demo_net;

internal static class Program
{
    private const string ConnectionName = "AdventureWorks";

    private static async Task Main()
    {
        var configuration = BuildConfiguration();
        await using var context = CreateDbContext(configuration);

        Console.WriteLine("AdventureWorks console demo\n");

        await ShowPersonCountAsync(context);
        Console.WriteLine();

        await ShowRecentProductsAsync(context);
        Console.WriteLine();

        await ShowTopTerritorySalesAsync(context);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        return new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false)
            .AddEnvironmentVariables()
            .Build();
    }

    private static AdventureWorksDbContext CreateDbContext(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString(ConnectionName)
            ?? throw new InvalidOperationException($"{ConnectionName} connection string is not configured.");

        var options = new DbContextOptionsBuilder<AdventureWorksDbContext>()
            .UseSqlServer(connectionString, sql => sql.EnableRetryOnFailure())
            .Options;

        return new AdventureWorksDbContext(options);
    }

    private static async Task ShowPersonCountAsync(AdventureWorksDbContext context)
    {
        var peopleCount = await context.Persons.CountAsync();
        Console.WriteLine($"AdventureWorks contains {peopleCount:N0} people records.");
    }

    private static async Task ShowRecentProductsAsync(AdventureWorksDbContext context)
    {
        var recentProducts = await context.Products
            .AsNoTracking()
            .OrderByDescending(product => product.SellStartDate)
            .Take(5)
            .Select(product => new
            {
                product.ProductId,
                product.Name,
                product.ListPrice,
                product.SellStartDate
            })
            .ToListAsync();

        if (recentProducts.Count == 0)
        {
            Console.WriteLine("No products found in the database.");
            return;
        }

        Console.WriteLine("Five most recently launched products:");
        foreach (var product in recentProducts)
        {
            Console.WriteLine(
                $"  {product.ProductId}: {product.Name} – {product.ListPrice:C} (since {product.SellStartDate:d})");
        }
    }

    private static async Task ShowTopTerritorySalesAsync(AdventureWorksDbContext context)
    {
        var topTerritories = await context.SalesOrderHeaders
            .AsNoTracking()
            .Where(order => order.TerritoryId != null)
            .GroupBy(order => order.TerritoryId!.Value)
            .Select(group => new
            {
                TerritoryId = group.Key,
                TotalSales = group.Sum(order => order.TotalDue)
            })
            .OrderByDescending(result => result.TotalSales)
            .Take(5)
            .Join(
                context.SalesTerritories.AsNoTracking(),
                sales => sales.TerritoryId,
                territory => territory.TerritoryId,
                (sales, territory) => new
                {
                    territory.Name,
                    territory.Group,
                    sales.TotalSales
                })
            .OrderByDescending(item => item.TotalSales)
            .ToListAsync();

        if (topTerritories.Count == 0)
        {
            Console.WriteLine("No sales orders available to calculate territory totals.");
            return;
        }

        Console.WriteLine("Top 5 sales territories by total sales:");
        foreach (var territory in topTerritories)
        {
            Console.WriteLine($"  {territory.Name} ({territory.Group}) – {territory.TotalSales:C}");
        }
    }
}
