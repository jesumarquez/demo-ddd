using hornero.demo.ddd.domain.interfaces;
using hornero.demo.ddd.kernel;
using hornero.demo.ddd.webapi.contract.Cliente;
using Microsoft.AspNetCore.Mvc;

namespace hornero.demo.ddd.webapi.Controllers;

[Route("[controller]")]
[ApiController]
public class ClienteController : ControllerBase
{
    private readonly IClienteService _clienteService;

    public ClienteController(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateClient(CreateClienteRequest clienteRequest)
    {
        var client = await _clienteService.CrearCliente(clienteRequest.Nombre,
                                                        clienteRequest.Apellido,
                                                        new Email(clienteRequest.Email));
        var response = new CreateClienteResponse(client.Nombre,
                                                 client.Apellido,
                                                 client.Email.Value,
                                                 client.Id.ToString());    

        return Created($"/cliente/{response.Id}", response);
    }
}