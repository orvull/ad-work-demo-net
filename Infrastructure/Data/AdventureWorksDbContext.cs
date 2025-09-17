using ad_work_demo_net.Application.Abstractions.Data;
using ad_work_demo_net.Domain.Entities.Person;
using ad_work_demo_net.Domain.Entities.Production;
using ad_work_demo_net.Domain.Entities.Sales;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Infrastructure.Data;

public class AdventureWorksDbContext : DbContext, IAdventureWorksDbContext
{
    public AdventureWorksDbContext(DbContextOptions<AdventureWorksDbContext> options)
        : base(options)
    {
    }

    public DbSet<Person> Persons => Set<Person>();

    public DbSet<Product> Products => Set<Product>();

    public DbSet<SalesOrderHeader> SalesOrderHeaders => Set<SalesOrderHeader>();

    public DbSet<SalesOrderDetail> SalesOrderDetails => Set<SalesOrderDetail>();

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        => base.SaveChangesAsync(cancellationToken);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AdventureWorksDbContext).Assembly);
    }
}
