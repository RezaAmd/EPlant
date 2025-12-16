namespace Domain.Entities.UserPlant;

public sealed class UserSowingActionEntity : BaseEntity
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public Guid UserPlantId { get; private set; }
    public DateTime SowingDate { get; private set; }
    public string? Notes { get; private set; }

    public static UserSowingActionEntity Create(
    Guid userPlantId,
    DateTime sowingDate,
    string? notes = null)
    {
        return new UserSowingActionEntity
        {
            UserPlantId = userPlantId,
            SowingDate = sowingDate,
            Notes = notes
        };
    }

}