using BattleBard.Data.DTO;
using Microsoft.EntityFrameworkCore;

namespace BattleBard.Data.Repositories;

public interface IUserRepository
{
    public Task<List<User>> GetUsers();
    public Task<User> CreateUser(User user);
    public Task<User?> GetUserById(Guid userId);
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
    
    public async Task<User?> GetUserById(Guid userId)
    {
        return await _context.Users.FindAsync(userId);
    } 

    public async Task<User> CreateUser(User user)
    {
        var newUser = await _context.Users.AddAsync(user);

        await _context.SaveChangesAsync();

        return newUser.Entity;
    }
}