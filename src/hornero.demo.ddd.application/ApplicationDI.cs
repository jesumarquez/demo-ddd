using hornero.demo.ddd.application.Services;
using hornero.demo.ddd.domain.interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace hornero.demo.ddd.application;

public static class ApplicationDI
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IClienteService, ClienteService>();

        return services;
    }
}