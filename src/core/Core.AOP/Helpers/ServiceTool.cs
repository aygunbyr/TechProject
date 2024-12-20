﻿
using Microsoft.Extensions.DependencyInjection;

namespace Core.AOP.Helpers;

public static class ServiceTool
{
    public static IServiceProvider ServiceProvider { get; private set; }

    public static IServiceCollection Create(IServiceCollection services)
    {
        ServiceProvider = services.BuildServiceProvider();
        return services;
    }
}
