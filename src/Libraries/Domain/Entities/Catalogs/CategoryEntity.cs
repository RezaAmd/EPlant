namespace Domain.Entities.Catalogs;

public sealed class CategoryEntity : BaseEntity
{
    public Guid Id { get; set; }
    public string Name { get; private set; } = string.Empty;
    public string? Description { get; set; }

    #region Relations

    #endregion

    #region Methods
    public static CategoryEntity Create(string name, string? description)
    {
        var category = new CategoryEntity()
        {
            Name = name,
            Description = description
        };

        return category;
    }
    #endregion
}