using DJ_AVA.Models;
using Microsoft.EntityFrameworkCore;

namespace DJ_AVA.Persistence
{
	public class DjAvaDbContext(DbContextOptions options):DbContext(options)
	{
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
        public DbSet<Event>	Events{ get; set; }
    }
}
