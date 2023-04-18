namespace BattleBard.Data.DTO;

public class Character
{
    public Guid Id { get; set; } = Guid.Empty;
    public string Name { get; set; } = string.Empty;

    public User User { get; set; }
    public Group Group { get; set; }
}