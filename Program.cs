using System.Collections.Generic;
using ad_work_demo_net.Application.People.Models;
using ad_work_demo_net.Application.People.Queries;
using ad_work_demo_net.Application.Sales.Models;
using ad_work_demo_net.Application.Sales.Queries;
using ad_work_demo_net.Infrastructure.DependencyInjection;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAdventureWorksDataAccess(builder.Configuration);

builder.Services.AddScoped<GetPeopleQueryHandler>();
builder.Services.AddScoped<GetSalesOrderWithDetailsQueryHandler>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var peopleGroup = app.MapGroup("/api/people");

peopleGroup.MapGet("/", async (string? search, int? take, GetPeopleQueryHandler handler, CancellationToken cancellationToken) =>
    {
        var takeValue = take is > 0 and <= 200 ? take.Value : 25;
        var people = await handler.HandleAsync(new GetPeopleQuery(search, takeValue), cancellationToken);
        return Results.Ok(people);
    })
    .WithName("GetPeople")
    .Produces<IReadOnlyList<PersonSummaryDto>>()
    .WithOpenApi(operation =>
    {
        operation.Summary = "Gets AdventureWorks people records with optional filtering.";
        operation.Description = "Returns up to 200 contacts ordered by last name. Pass a search term to filter by name.";
        return operation;
    });

app.MapGet("/api/sales/orders/{orderId:int}", async (int orderId, GetSalesOrderWithDetailsQueryHandler handler, CancellationToken cancellationToken) =>
    {
        var order = await handler.HandleAsync(new GetSalesOrderWithDetailsQuery(orderId), cancellationToken);
        return order is not null ? Results.Ok(order) : Results.NotFound();
    })
    .WithName("GetSalesOrderById")
    .Produces<SalesOrderDto>()
    .Produces(StatusCodes.Status404NotFound)
    .WithOpenApi(operation =>
    {
        operation.Summary = "Gets a sales order with nested details.";
        operation.Description = "Looks up an individual sales order header with line items projected from the AdventureWorks OLTP database.";
        return operation;
    });

app.Run();
