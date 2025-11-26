using Domain.Entities.Catalogs;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace Application.Common.Interfaces;

public interface IAppDbContext
{
    #region Tables
    DbSet<PlantSpecyEntity> PlantSpecies { get; }
    DbSet<PlantEntity> Plants { get; }
    #endregion

    ChangeTracker ChangeTracker { get; }
    DatabaseFacade Database { get; }

    DbSet<TEntity> Set<TEntity>() where TEntity : class;
    EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    Task<Result> SaveChangeAsync(CancellationToken cancellationToken = default);
    Task<IDbContextTransaction> BeginTransactionAsync();
}