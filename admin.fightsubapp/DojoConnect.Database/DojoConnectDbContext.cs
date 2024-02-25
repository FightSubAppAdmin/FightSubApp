using DojoConnect.Database.models;
using Microsoft.EntityFrameworkCore;

namespace DojoConnect.Database;

public class DojoConnectDbContext : DbContext
{
    public DojoConnectDbContext(DbContextOptions<DojoConnectDbContext> options)
        : base(options)
    {
    }

    public DbSet<Gym> Gyms { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Gym>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity
                .HasMany(e => e.Persons)
                .WithOne(e => e.Gym)
                .HasForeignKey(e => e.GymId)
                .HasPrincipalKey(e => e.Id);
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
        });

    }
}