using MauiOpenGym.ViewModels;
using MauiOpenGym.Views.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiOpenGym.Core.Utils.Extensions;

public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddProjectPages(
        this IServiceCollection services)
    {
        return services.AddDerivedTypes<BasePages>();
    }

    public static IServiceCollection AddProjectViewModels(
        this IServiceCollection services)
    {
        return services.AddDerivedTypes<BaseViewModels>();
    }

    private static IServiceCollection AddDerivedTypes<TBase>(
        this IServiceCollection services)
    {
        var assembly = typeof(TBase).Assembly;

        var types = assembly
            .GetTypes()
            .Where(type =>
                !type.IsAbstract &&
                !type.IsInterface &&
                typeof(TBase).IsAssignableFrom(type));

        foreach (var type in types)
        {
            services.AddTransient(type);
        }

        return services;
    }
}
