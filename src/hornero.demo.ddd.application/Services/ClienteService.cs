using System;
using hornero.demo.ddd.domain.ClienteAgregates;
using hornero.demo.ddd.domain.interfaces;
using hornero.demo.ddd.kernel;

namespace hornero.demo.ddd.application.Services;

public class ClienteService : IClienteService
{
    private readonly IRepository<Cliente, Guid> _clienteRepository;

    public ClienteService(IRepository<Cliente,Guid> clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }
    
    public Cliente CrearCliente(string nombre, string apellido, Email email)
    {
        var nuevoCliente = Cliente.CrearNuevoCliente(nombre, apellido, email);

        _clienteRepository.Add(nuevoCliente);

        return nuevoCliente;
    }
}
