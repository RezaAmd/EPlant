namespace Domain.Entities.Users;

public class UserPlantEntity : BaseEntity
{
    public Guid Id { get; init; } = Guid.NewGuid();

    public required Guid PlantId { get; set; }
    public Guid PropagationRecipeId { get; set; }

    public long? SowingDate { get; private set; }
    public long CreatedOn { get; init; } = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

    public ICollection<UserStageInstanceEntity> Stages { get; set; } = [];

    #region Methods
    public void Planted()
    {
        SowingDate = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
    }
    #endregion
}