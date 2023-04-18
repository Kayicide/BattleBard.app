using BattleBard.Data.DTO;
using BattleBard.Data.Repositories;

namespace BattleBard.Features;

public interface IUserService
{
    public Task<List<User>> GetUsers();
    public Task<User> CreateUser();
    public Task<User?> GetUserById(Guid id);
}

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<List<User>> GetUsers()
    {
        return await _userRepository.GetUsers();
    }

    public async Task<User?> GetUserById(Guid id)
    {
        return await _userRepository.GetUserById(id);
    }

    public async Task<User> CreateUser()
    {
        var user = new User()
        {
            Id = Guid.NewGuid(),
            Username = "Test"
        };

        return await _userRepository.CreateUser(user);
    }
}