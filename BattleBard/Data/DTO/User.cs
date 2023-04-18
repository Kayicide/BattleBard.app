namespace BattleBard.Data.DTO;

public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; }

    public IList<Group> Groups { get; set; } = new List<Group>();
    
}