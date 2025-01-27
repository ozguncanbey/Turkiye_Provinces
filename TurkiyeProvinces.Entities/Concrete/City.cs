using TurkiyeProvinces.Core.Entities;

namespace TurkiyeProvinces.Entities.Concrete;

public class City : IEntity
{
    public virtual int Id { get; set; }
    public virtual string Name { get; set; }
    public virtual int Plate { get; set; }
}