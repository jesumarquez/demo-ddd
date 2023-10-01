using hornero.demo.ddd.application.Services;
using hornero.demo.ddd.domain.ClienteAgregates;
using hornero.demo.ddd.infrastructure.Repositories;
using hornero.demo.ddd.kernel;

namespace hornero.demo.ddd.application.test;

public class ClienteServiceTest
{
    [Fact]
    public void ClientService_CrearCliente()
    {
        IRepository<Cliente,Guid> clienteReposity = new ClienteRepository();
        var clienteService = new ClienteService(clienteReposity);

        var cliente = clienteService.CrearCliente("pedro","perez", new Email("pedroperez@email.com"));

        Assert.NotNull(cliente);
    }
}