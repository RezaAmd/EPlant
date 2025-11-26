using Domain.Entities.Users;

namespace Domain.Entities.Catalogs;

public sealed class PlantSpeciesEntity : BaseEntity
{
    public Guid Id { get; set; }
    public string Name { get; private set; } = string.Empty;
    public string? ScientificName { get; set; }
    public string? Description { get; set; }

    #region Relations
    public ICollection<UserPlantEntity> UserPlants { get; set; } = [];
    #endregion

    #region Methods
    public static PlantSpeciesEntity Create(string name, string? ScientificName, string? description)
    {
        var category = new PlantSpeciesEntity()
        {
            Name = name,
            ScientificName = ScientificName,
            Description = description
        };

        return category;
    }
    #endregion
}