namespace Domain.Entities.Recipes;

public class StageRequiredAction : BaseEntity
{
    public Guid Id { get; init; } = Guid.NewGuid();

    public Guid StageDefinitionId { get; set; }
    public ActionType ActionType { get; set; }

    public bool IsMandatory { get; set; }
    public int? DueStartDay { get; set; }
    public int? DueEndDay { get; set; }

    public StageDefinition? Definition { get; set; }
}