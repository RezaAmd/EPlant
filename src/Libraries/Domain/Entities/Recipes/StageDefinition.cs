namespace Domain.Entities.Recipes;

public class StageDefinition : BaseEntity
{
    public Guid Id { get; init; } = Guid.NewGuid();

    public Guid PropagationRecipeId { get; set; }
    public StageType Type { get; set; }

    public int ExpectedMinDays { get; set; }
    public int ExpectedMaxDays { get; set; }

    public ICollection<StageRequiredAction> RequiredActions { get; set; } = [];
}