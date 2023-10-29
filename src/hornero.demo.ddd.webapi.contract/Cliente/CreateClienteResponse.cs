namespace hornero.demo.ddd.webapi.contract.Cliente;

public record CreateClienteResponse(
    string Nombre,
    string Apellido,
    string Email,
    string Id
);