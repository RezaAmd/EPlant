namespace Domain.Entities.UserPlant;

public class PlantActivityEventEntity
{
    public Guid Id { get; private set; }
    public Guid UserPlantId { get; private set; }
    public PlantActivityTypeEnum ActivityType { get; private set; }
    public double? NumericValue { get; private set; }
    public string? Unit { get; private set; }
    public DateTime Timestamp { get; private set; }

    private PlantActivityEventEntity() { }

    public static PlantActivityEventEntity Create(
        Guid userPlantId,
        PlantActivityTypeEnum activityType,
        double? numericValue = null,
        string? unit = null,
        DateTime? timestamp = null)
    {
        return new PlantActivityEventEntity
        {
            Id = Guid.NewGuid(),
            UserPlantId = userPlantId,
            ActivityType = activityType,
            NumericValue = numericValue,
            Unit = unit,
            Timestamp = timestamp ?? DateTime.UtcNow
        };
    }
}