using System.Threading.Tasks;
using hornero.demo.ddd.domain.ClienteAgregates;
using hornero.demo.ddd.kernel;

namespace hornero.demo.ddd.domain.interfaces;

public interface IClienteService 
{
    Task<Cliente> CrearCliente(string nombre, string apellido, Email email);     
}