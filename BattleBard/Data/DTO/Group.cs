namespace BattleBard.Data.DTO;

public class Group
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = "New Group!";

    public IList<User> Members { get; set; } = new List<User>();
}