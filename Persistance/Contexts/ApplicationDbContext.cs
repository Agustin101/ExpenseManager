using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opts) : base(opts)
    {
        
    }

    public DbSet<MoneyMovement> MoneyMovements { get; set; }
    public DbSet<MoneyMovementCategory> MoneyMovementCategories { get; set; }
}
