using Domain.Entities.Plants;
using Domain.Entities.UserPlant;
using Domain.Entities.Users;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace Application.Common.Interfaces;

public interface IAppDbContext
{
    #region Tables
    // Plant
    DbSet<PlantSpeciesEntity> PlantSpecies { get; }

    // User
    DbSet<UserPlantEntity> UserPlants { get; }
    DbSet<UserSowingActionEntity> UserSowingActions { get; }
    DbSet<PlantActivityEventEntity> plantActivityEvents { get; }
    DbSet<PlantNoteEntity> PlantNotes { get; }
    #endregion

    ChangeTracker ChangeTracker { get; }
    DatabaseFacade Database { get; }

    DbSet<TEntity> Set<TEntity>() where TEntity : class;
    EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    Task<Result> SaveChangeAsync(CancellationToken cancellationToken = default);
    Task<IDbContextTransaction> BeginTransactionAsync();
}