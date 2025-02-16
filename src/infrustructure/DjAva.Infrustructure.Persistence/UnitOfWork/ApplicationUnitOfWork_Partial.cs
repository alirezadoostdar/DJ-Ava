using DjAva.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DjAva.Infrastructure.Persistence.UnitOfWork;

public partial class ApplicationUnitOfWork
{
	public DbSet<User> Users => _context.Set<User>();
}
