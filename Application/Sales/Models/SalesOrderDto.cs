namespace ad_work_demo_net.Application.Sales.Models;

public sealed record SalesOrderDto(
    int SalesOrderId,
    string SalesOrderNumber,
    DateTime OrderDate,
    DateTime DueDate,
    DateTime? ShipDate,
    decimal SubTotal,
    decimal TaxAmount,
    decimal Freight,
    decimal TotalDue,
    IReadOnlyList<SalesOrderDetailDto> Details);
