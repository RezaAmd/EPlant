namespace Domain.Entities.Users;

public class UserMeasurementEntity : BaseEntity
{
    public Guid Id { get; init; } = Guid.NewGuid();

    public Guid UserPlantInstanceId { get; set; }
    public Guid StageId { get; set; }

    public MeasurementType Type { get; set; }
    public double Value { get; set; }
    public string Unit { get; set; }

    public DateTime CreatedAt { get; set; }
}