namespace Domain.Entities.Collections;

public class UserPlantEntity : BaseEntity
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public required Guid PlantId { get; set; }
    public long? PlantedOn { get; private set; }
    public long CreatedOn { get; init; } = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
}