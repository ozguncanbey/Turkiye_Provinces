using TurkiyeProvinces.Core.Entities;

namespace TurkiyeProvinces.Core.DataAccess;

public interface IQueryableRepository<out T> where T : class, IEntity, new()
{
    IQueryable<T> Table { get; }
}