using DataAccessLayer.Model.Entities;
using DataAccessLayer.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace DataAccessLayer.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {
            try
            {
                var databaseCreator = Database.GetService<IRelationalDatabaseCreator>() as RelationalDatabaseCreator;
                if (databaseCreator != null)
                {
                    if (!databaseCreator.CanConnect()) databaseCreator.Create();
                    if (!databaseCreator.HasTables()) databaseCreator.CreateTables();
                }
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        public DbSet<User> Users { get; set; }
        public DbSet<MemoryArea> MemoryAreas { get; set; }
        public DbSet<Metadata> Metadatas { get; set; }
        public DbSet<Modifier> Modifiers { get; set; }
        public DbSet<Tier> Tiers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // N:M Relationship between User and MemoryArea
            modelBuilder.Entity<User>().
                HasMany(u => u.MemoryAreasPartecipated).
                WithMany(m => m.Users).
                UsingEntity<Partecipate>();

            // N:M Relatioship between User and User through Friendship
            modelBuilder.Entity<Friendship>()
            .HasKey(f => new { f.UserId, f.FriendId });

            modelBuilder.Entity<Friendship>()
                .HasOne(f => f.User)
                .WithMany(u => u.Friendships)
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Restrict);



        }
    }
}
