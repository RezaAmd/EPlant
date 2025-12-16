namespace Domain.Entities.UserPlant;

/// <summary>
/// Free-form notes by the user for any plant instance
/// </summary>
public class PlantNoteEntity
{
    public Guid Id { get; private set; }
    public Guid UserPlantId { get; private set; }
    public string Note { get; private set; } = string.Empty;
    public long CreatedOn { get; private set; } = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

    #region Relationships

    #endregion

    #region Methods
    public static PlantNoteEntity Create(Guid userPlantId, string note)
    {
        return new PlantNoteEntity
        {
            Id = Guid.NewGuid(),
            UserPlantId = userPlantId,
            Note = note
        };
    }
    #endregion
}