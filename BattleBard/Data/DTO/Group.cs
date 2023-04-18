namespace BattleBard.Data.DTO;

public class Group
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;

    public IList<User> Members { get; set; } = new List<User>();
    public IList<Character> Characters { get; set; } = new List<Character>();
}