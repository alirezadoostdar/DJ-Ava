﻿using DjAva.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DjAva.Infrastructure.Persistence.Configuration;

public class UserConfig : IEntityTypeConfiguration<User>
{
	public void Configure(EntityTypeBuilder<User> builder)
	{
		builder.Property(u => u.FirstName)
			   .HasMaxLength(50)
			   .IsRequired();

		builder.Property(u => u.LastName)
			   .HasMaxLength(50)
			   .IsRequired();

		builder.Property(u => u.Email)
			   .HasMaxLength(50)
			   .IsRequired();

		builder.Property(u => u.Password)
			   .HasMaxLength(50)
			   .IsRequired();

		builder.ComplexProperty(u => u.Address);
	}
}
