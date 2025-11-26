namespace Domain.Entities.Catalogs;

public sealed class PlantEntity : BaseEntity
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Name { get; private set; } = string.Empty;
    public string? Description { get; set; }

    #region Relations

    #endregion

    #region Methods
    public static PlantEntity Create(string name, string? description)
    {
        var plant = new PlantEntity()
        {
            Name = name,
            Description = description
        };

        return plant;
    }
    #endregion
}