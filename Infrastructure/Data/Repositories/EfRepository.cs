using System.Linq;
using System.Linq.Expressions;
using ad_work_demo_net.Application.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Infrastructure.Data.Repositories;

public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly AdventureWorksDbContext _dbContext;
    private readonly DbSet<TEntity> _dbSet;

    public EfRepository(AdventureWorksDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<TEntity>();
    }

    public async Task<TEntity?> GetByIdAsync(CancellationToken cancellationToken, params object[] keyValues)
    {
        var entity = await _dbSet.FindAsync(keyValues.Cast<object?>().ToArray(), cancellationToken);
        return entity;
    }

    public Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        => _dbSet.AsNoTracking().FirstOrDefaultAsync(predicate, cancellationToken);

    public async Task<IReadOnlyList<TEntity>> ListAsync(CancellationToken cancellationToken = default)
    {
        var results = await _dbSet.AsNoTracking().ToListAsync(cancellationToken);
        return results;
    }

    public async Task<IReadOnlyList<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
    {
        var results = await _dbSet.AsNoTracking().Where(predicate).ToListAsync(cancellationToken);
        return results;
    }

    public async Task<IReadOnlyList<TResult>> ListAsync<TResult>(Func<IQueryable<TEntity>, IQueryable<TResult>> queryShaper, CancellationToken cancellationToken = default)
    {
        var query = queryShaper(_dbSet.AsNoTracking());
        return await query.ToListAsync(cancellationToken);
    }

    public Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        => _dbSet.AnyAsync(predicate, cancellationToken);

    public Task<int> CountAsync(CancellationToken cancellationToken = default)
        => _dbSet.CountAsync(cancellationToken);

    public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        await _dbSet.AddAsync(entity, cancellationToken);
        return entity;
    }

    public Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
        => _dbSet.AddRangeAsync(entities, cancellationToken);

    public void Update(TEntity entity)
        => _dbSet.Update(entity);

    public void Remove(TEntity entity)
        => _dbSet.Remove(entity);

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        => _dbContext.SaveChangesAsync(cancellationToken);
}
