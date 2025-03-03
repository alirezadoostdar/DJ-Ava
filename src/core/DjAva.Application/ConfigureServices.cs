﻿using DjAva.Application.Common.Behaviours;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace DjAva.Application;

public static class ConfigureServices
{
    public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
        });

        //  services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}
