using BattleBard.Data.DTO;
using BattleBard.Data.Repositories;

namespace BattleBard.Features;

public interface IUserService
{
    public Task<List<User>> GetUsers();
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
}