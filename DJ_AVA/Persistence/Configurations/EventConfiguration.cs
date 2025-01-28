using DJ_AVA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DJ_AVA.Persistence.Configurations
{
	public class EventConfiguration : IEntityTypeConfiguration<Event>
	{
		public void Configure(EntityTypeBuilder<Event> builder)
		{
			builder.HasKey(x => x.Id);
							
			builder.Property(x=>x.Title).IsRequired().HasMaxLength(200);
			builder.Property(x=>x.Date).IsRequired();

			builder.Property(x => x.Location).IsRequired().HasMaxLength(200);

			builder.Property(x => x.Description).HasMaxLength(500);
		}
	}
}
