﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DjAva.Infrastructure;

public static class ConfigureServices
{
	public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services)
	{
		services.AddHttpClient();

		services.AddMediatR(cfg =>
		{
			cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
		});
		return services;
	}
}
