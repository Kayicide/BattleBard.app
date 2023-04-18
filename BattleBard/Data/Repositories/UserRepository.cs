using BattleBard.Data.DTO;
using Microsoft.EntityFrameworkCore;

namespace BattleBard.Data.Repositories;

public interface IUserRepository
{
    public Task<List<User>> GetUsers();
}

public class UserRepository : IUserRepository
{
    private readonly DataContext _context;
    public UserRepository(DataContext context)
    {
        _context = context;
    }
    public async Task<List<User>> GetUsers()
    {
        return await _context.Users.ToListAsync();
    }
}