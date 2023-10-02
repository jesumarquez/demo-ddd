using hornero.demo.ddd.kernel;
using System;

namespace hornero.demo.ddd.domain.ClienteAgregates;

public sealed class Cliente : BaseEntity<Guid>, IAggregateRoot
{
    public string Nombre { get; private set; }
    public string Apellido { get; private set; }
    public Email Email { get; private set;}

    private Cliente(Guid id, string nombre, string apellido, Email email): base(id)
    {
        Nombre = nombre;
        Apellido = apellido;
        Email = email;
    }

    public static Cliente CrearNuevoCliente(string nombre, string apellido, Email email) =>
        new Cliente(Guid.NewGuid(), nombre, apellido, email);
}