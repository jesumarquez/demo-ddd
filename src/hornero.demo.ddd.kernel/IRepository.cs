using System.Threading.Tasks;

namespace hornero.demo.ddd.kernel;

public interface IRepository<T,TId> where T : class, IAggregateRoot
{
    Task<T> Add(T entity);
}
