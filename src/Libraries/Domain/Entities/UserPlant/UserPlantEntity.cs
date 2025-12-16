using Domain.Entities.Plants;
using Domain.Entities.UserPlant;

namespace Domain.Entities.Users;

public class UserPlantEntity : BaseEntity
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public required Guid PlantSpeciesId { get; set; }
    public long? SowingDate { get; private set; }
    public long CreatedOn { get; init; } = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

    #region Relationships
    public PlantSpeciesEntity? Species { get; set; }
    public UserSowingActionEntity? SowingAction { get; private set; }
    public ICollection<PlantActivityEventEntity> ActivityEvents { get; private set; } = new List<PlantActivityEventEntity>();
    public ICollection<PlantNoteEntity> Notes { get; private set; } = new List<PlantNoteEntity>();
    #endregion

    #region Methods
    public void Planted()
    {
        SowingDate = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
    }
    #endregion
}