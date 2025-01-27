using FluentNHibernate.Mapping;
using TurkiyeProvinces.Entities.Concrete;

namespace TurkiyeProvinces.DataAccess.Concrete.NHibernate.Mappings;

public class CityMap : ClassMap<City>
{
    public CityMap()
    {
        Table("city");
        LazyLoad();
        Id(x => x.Id).Column("id");
        Map(x => x.Name).Column("name");
        Map(x => x.Plate).Column("plate");
    }
}