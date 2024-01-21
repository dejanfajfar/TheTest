using API.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Persistence;

public class DatabaseContext : DbContext
{
    public DbSet<NoteEntity> Notes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Username=sa;Password=Pass1234;Database=TheTest");
    }
}