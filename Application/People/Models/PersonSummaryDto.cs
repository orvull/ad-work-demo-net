namespace ad_work_demo_net.Application.People.Models;

public sealed record PersonSummaryDto(int BusinessEntityId, string FirstName, string LastName, string? MiddleName, string? Title);
