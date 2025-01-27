using TurkiyeProvinces.Core.DataAccess.NHibernate;
using TurkiyeProvinces.DataAccess.Abstract;
using TurkiyeProvinces.Entities.Concrete;

namespace TurkiyeProvinces.DataAccess.Concrete.NHibernate;

public class NhCityDal : NhEntityRepositoryBase<City>, ICityDal
{
    public NhCityDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
    {
    }
}