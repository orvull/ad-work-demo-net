using System.Linq.Expressions;

namespace ad_work_demo_net.Application.Abstractions.Repositories;

public interface IReadRepository<T> where T : class
{
    Task<T?> GetByIdAsync(CancellationToken cancellationToken, params object[] keyValues);

    Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

    Task<IReadOnlyList<T>> ListAsync(CancellationToken cancellationToken = default);

    Task<IReadOnlyList<T>> ListAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

    Task<IReadOnlyList<TResult>> ListAsync<TResult>(Func<IQueryable<T>, IQueryable<TResult>> queryShaper, CancellationToken cancellationToken = default);

    Task<bool> AnyAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

    Task<int> CountAsync(CancellationToken cancellationToken = default);
}
