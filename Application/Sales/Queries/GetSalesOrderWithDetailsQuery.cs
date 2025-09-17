using System.Linq;
using ad_work_demo_net.Application.Abstractions.Repositories;
using ad_work_demo_net.Application.Sales.Models;
using ad_work_demo_net.Domain.Entities.Sales;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Application.Sales.Queries;

public sealed record GetSalesOrderWithDetailsQuery(int SalesOrderId);

public sealed class GetSalesOrderWithDetailsQueryHandler
{
    private readonly IReadRepository<SalesOrderHeader> _ordersRepository;

    public GetSalesOrderWithDetailsQueryHandler(IReadRepository<SalesOrderHeader> ordersRepository)
    {
        _ordersRepository = ordersRepository;
    }

    public async Task<SalesOrderDto?> HandleAsync(GetSalesOrderWithDetailsQuery query, CancellationToken cancellationToken = default)
    {
        var orders = await _ordersRepository.ListAsync(orderQuery =>
            orderQuery
                .Where(o => o.SalesOrderId == query.SalesOrderId)
                .AsSplitQuery()
                .Select(o => new SalesOrderDto(
                    o.SalesOrderId,
                    o.SalesOrderNumber,
                    o.OrderDate,
                    o.DueDate,
                    o.ShipDate,
                    o.SubTotal,
                    o.TaxAmt,
                    o.Freight,
                    o.TotalDue,
                    o.SalesOrderDetails
                        .OrderBy(d => d.SalesOrderDetailId)
                        .Select(d => new SalesOrderDetailDto(
                            d.SalesOrderId,
                            d.SalesOrderDetailId,
                            d.OrderQty,
                            d.ProductId,
                            d.Product.Name,
                            d.UnitPrice,
                            d.UnitPriceDiscount,
                            d.LineTotal))
                        .ToList()))
            , cancellationToken);

        return orders.SingleOrDefault();
    }
}
