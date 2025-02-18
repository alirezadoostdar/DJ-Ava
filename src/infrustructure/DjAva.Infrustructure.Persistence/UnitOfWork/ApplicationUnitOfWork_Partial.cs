using DjAva.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DjAva.Infrastructure.Persistence.Context;

public partial class ApplicationUnitOfWork
{
    public DbSet<User> Users => _context.Set<User>();
}
