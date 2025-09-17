using System.Linq;
using ad_work_demo_net.Application.People.Models;
using ad_work_demo_net.Domain.Entities.Person;
using ad_work_demo_net.Application.Abstractions.Repositories;

namespace ad_work_demo_net.Application.People.Queries;

public sealed record GetPeopleQuery(string? SearchTerm = null, int Take = 25);

public sealed class GetPeopleQueryHandler
{
    private readonly IReadRepository<Person> _peopleRepository;

    public GetPeopleQueryHandler(IReadRepository<Person> peopleRepository)
    {
        _peopleRepository = peopleRepository;
    }

    public Task<IReadOnlyList<PersonSummaryDto>> HandleAsync(GetPeopleQuery query, CancellationToken cancellationToken = default)
    {
        return _peopleRepository.ListAsync(persons =>
        {
            var queryable = persons
                .OrderBy(p => p.LastName)
                .ThenBy(p => p.FirstName);

            if (!string.IsNullOrWhiteSpace(query.SearchTerm))
            {
                var term = query.SearchTerm.Trim();
                queryable = queryable.Where(p => p.FirstName.Contains(term) || p.LastName.Contains(term));
            }

            queryable = queryable.Take(query.Take);

            return queryable.Select(p => new PersonSummaryDto(
                p.BusinessEntityId,
                p.FirstName,
                p.LastName,
                p.MiddleName,
                p.Title));
        }, cancellationToken);
    }
}
