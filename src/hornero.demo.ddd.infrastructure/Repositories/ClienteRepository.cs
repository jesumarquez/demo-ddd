using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using hornero.demo.ddd.domain.ClienteAgregates;
using hornero.demo.ddd.kernel;

namespace hornero.demo.ddd.infrastructure.Repositories;

public class ClienteRepository : IRepository<Cliente, Guid>
{
    private readonly List<Cliente> _clientes = new List<Cliente>();

    public Task<Cliente> Add(Cliente entity)
    {
        _clientes.Add(entity);

        return Task.FromResult(entity);
    }
}
