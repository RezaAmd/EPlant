using Domain.Entities.Users;

namespace Domain.Entities.Plants;

/// <summary>
/// plant species; Name, scientific name, suitable reproduction interval
/// </summary>
public class PlantSpeciesEntity
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Name { get; private set; } = string.Empty;
    public string? ScientificName { get; set; }
    public string? Description { get; set; }

    #region Relations
    public ICollection<UserPlantEntity> UserPlants { get; set; } = [];
    #endregion

    #region Methods
    public static PlantSpeciesEntity Create(string name, string? description)
    {
        var plant = new PlantSpeciesEntity()
        {
            Name = name,
            Description = description
        };

        return plant;
    }
    #endregion

}