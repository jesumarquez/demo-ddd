using hornero.demo.ddd.application.Services;
using hornero.demo.ddd.domain.ClienteAgregates;
using hornero.demo.ddd.infrastructure.Repositories;
using hornero.demo.ddd.kernel;
using Moq;

namespace hornero.demo.ddd.application.test;

public class ClienteServiceTest
{
    [Fact]
    public async void ClientService_CrearCliente()
    {
        Cliente clienteEsperado = Cliente.CrearNuevoCliente("pedro","perez", new Email("pedroperez@email.com"));

        Mock<IRepository<Cliente,Guid>> clienteReposity = new Mock<IRepository<Cliente, Guid>>();
        clienteReposity
            .Setup(r => r.Add(It.IsAny<Cliente>()))
            .Returns(Task.FromResult(clienteEsperado));

        var clienteService = new ClienteService(clienteReposity.Object);

        var cliente = await clienteService.CrearCliente("pedro","perez", new Email("pedroperez@email.com"));

        Assert.True(clienteEsperado.Equals(cliente), "Los datos del cliente creado no son los esperados.");
    }
}