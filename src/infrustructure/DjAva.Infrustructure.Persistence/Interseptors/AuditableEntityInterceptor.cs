using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DjAva.Infrastructure.Persistence.Interseptors;

public class AuditableEntityInterceptor : SaveChangesInterceptor
{
}
