using Microsoft.EntityFrameworkCore;
using EventSourcing.Events.Core;
using Microsoft.Extensions.Logging;

namespace EventSourcing.Data
{
    public class EventStoreSqlContext : DbContext 
    {
        private const string SqlConfig = "Data Source = localhost,1433;Database= EventSourcing;User ID = sa;Password = Password123 ";

        public EventStoreSqlContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<StoredEvent> storedEvents {get; set;}
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(SqlConfig);  
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}