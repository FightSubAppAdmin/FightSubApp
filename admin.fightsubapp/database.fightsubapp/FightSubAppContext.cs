using database.fightsubapp.models;
using Microsoft.EntityFrameworkCore;

namespace database.fightsubapp;

public class FightSubAppContext : DbContext
{
    public FightSubAppContext(DbContextOptions<FightSubAppContext> options)
        : base(options)
    {
    }

    public DbSet<Gym> Gyms { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Gym>(entity =>
        {
            entity.HasKey(e => e.GymId);
            entity.Property(e => e.Name).HasMaxLength(250);
        });
        
    }
}