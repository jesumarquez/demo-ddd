namespace hornero.demo.ddd.webapi.contract.Cliente;

public record CreateClienteRequest(
    string Nombre,
    string Apellido,
    string Email
);