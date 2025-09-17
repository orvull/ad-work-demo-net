namespace ad_work_demo_net.Application.Sales.Models;

public sealed record SalesOrderDetailDto(
    int SalesOrderId,
    int SalesOrderDetailId,
    short OrderQuantity,
    int ProductId,
    string ProductName,
    decimal UnitPrice,
    decimal UnitPriceDiscount,
    decimal LineTotal);
