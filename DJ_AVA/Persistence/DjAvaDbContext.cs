using DJ_AVA.Models;
using DJ_AVA.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DJ_AVA.Persistence
{
	public class DjAvaDbContext(DbContextOptions options):DbContext(options)
	{
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfiguration(new EventConfiguration());
		}
        public DbSet<Event>	Events{ get; set; }
    }
}
