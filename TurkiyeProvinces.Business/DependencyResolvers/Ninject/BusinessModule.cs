using Ninject.Modules;
using TurkiyeProvinces.Business.Abstract;
using TurkiyeProvinces.Business.Concrete.Managers;
using TurkiyeProvinces.Core.DataAccess.NHibernate;
using TurkiyeProvinces.DataAccess.Abstract;
using TurkiyeProvinces.DataAccess.Concrete.NHibernate;
using TurkiyeProvinces.DataAccess.Concrete.NHibernate.Helpers;

namespace TurkiyeProvinces.Business.DependencyResolvers.Ninject;

public class BusinessModule : NinjectModule
{
    public override void Load()
    {
        Bind<ICityService>().To<CityManager>();
        Bind<ICityDal>().To<NhCityDal>();
        Bind<NHibernateHelper>().To<SqlServerHelper>();
    }
}