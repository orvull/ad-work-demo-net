using System.Collections.Generic;
using ad_work_demo_net.Application.Abstractions.Repositories;
using ad_work_demo_net.Infrastructure.Data.Repositories;

namespace ad_work_demo_net.Infrastructure.Data;

public class AdventureWorksUnitOfWork : IUnitOfWork
{
    private readonly AdventureWorksDbContext _dbContext;
    private readonly Dictionary<Type, object> _repositories = new();

    public AdventureWorksUnitOfWork(AdventureWorksDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
    {
        if (_repositories.TryGetValue(typeof(TEntity), out var repository))
        {
            return (IRepository<TEntity>)repository;
        }

        var newRepository = new EfRepository<TEntity>(_dbContext);
        _repositories[typeof(TEntity)] = newRepository;
        return newRepository;
    }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        => _dbContext.SaveChangesAsync(cancellationToken);
}
