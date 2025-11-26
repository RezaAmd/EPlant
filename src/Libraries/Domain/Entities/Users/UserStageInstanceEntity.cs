namespace Domain.Entities.Users;

public class UserStageInstanceEntity : BaseEntity
{
    public Guid Id { get; init; } = Guid.NewGuid();

    public Guid UserPlantInstanceId { get; set; }
    public Guid StageDefinitionId { get; set; }

    public DateTime StartedAt { get; set; }
    public DateTime? CompletedAt { get; set; }

    public ICollection<UserActionLogEntity> ActionLogs { get; set; }
    public ICollection<UserMeasurementEntity> Measurements { get; set; }
}