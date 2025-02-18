using DjAva.Application.Common;
using DjAva.Infrastructure.Persistence.Context;
using DjAva.Infrastructure.Persistence.Interseptors;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DjAva.Infrastructure.Persistence;

public static class ConfigureServices
{
	public static IServiceCollection RegisterPersistenceServices(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddScoped<AuditableEntityInterceptor>();

		services.AddDbContext<ApplicationDbContext>(options =>
			 options.UseSqlServer(configuration.GetConnectionString("ApplicationDbContext"),
				 builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

		services.AddScoped<IApplicationUnitOfWork, ApplicationUnitOfWork>();

		return services;
	}
}
