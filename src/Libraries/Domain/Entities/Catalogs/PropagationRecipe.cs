namespace Domain.Entities.Catalogs;

public class PropagationRecipe : BaseEntity
{
    public Guid Id { get; init; } = Guid.NewGuid();

    public Guid PlantId { get; set; }
    public PropagationMethod Method { get; set; }
    public DifficultyLevel Difficulty { get; set; }

    public ICollection<StageDefinition> Stages { get; set; } = [];
}