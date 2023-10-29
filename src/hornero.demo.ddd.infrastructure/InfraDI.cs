using System;
using hornero.demo.ddd.domain.ClienteAgregates;
using hornero.demo.ddd.infrastructure.Repositories;
using hornero.demo.ddd.kernel;
using Microsoft.Extensions.DependencyInjection;

namespace hornero.demo.ddd.infrastructure;

public static class InfraDI
{
    public static IServiceCollection AddInfra(this IServiceCollection services)
    {
        services.AddScoped<IRepository<Cliente,Guid>, ClienteRepository>();

        return services;
    }
}