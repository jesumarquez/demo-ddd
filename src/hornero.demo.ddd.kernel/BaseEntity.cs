using System;

namespace hornero.demo.ddd.kernel;

public abstract class BaseEntity<TId>
{
    public BaseEntity(TId id) => Id = id;
    public TId Id { get; private set; }
}
