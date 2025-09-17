using ad_work_demo_net.Domain.Entities.Person;
using ad_work_demo_net.Domain.Entities.Production;
using ad_work_demo_net.Domain.Entities.Sales;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Application.Abstractions.Data;

public interface IAdventureWorksDbContext
{
    DbSet<Person> Persons { get; }

    DbSet<Product> Products { get; }

    DbSet<SalesOrderHeader> SalesOrderHeaders { get; }

    DbSet<SalesOrderDetail> SalesOrderDetails { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
