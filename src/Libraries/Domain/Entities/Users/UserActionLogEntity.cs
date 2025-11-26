namespace Domain.Entities.Users;

public class UserActionLogEntity : BaseEntity
{
    public Guid Id { get; init; } = Guid.NewGuid();

    public Guid UserPlantInstanceId { get; set; }
    public Guid StageId { get; set; }

    public ActionType Type { get; set; }
    public Dictionary<string, string>? Metadata { get; set; }

    public DateTime CreatedAt { get; set; }
}