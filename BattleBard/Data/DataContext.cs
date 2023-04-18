using BattleBard.Data.DTO;

namespace BattleBard.Data;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
 public DataContext(DbContextOptions<DataContext> options) : base(options)
 {
 }

 public DbSet<User> Users => Set<User>();
 public DbSet<Group> Groups => Set<Group>();
}