using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using TurkiyeProvinces.Core.DataAccess.NHibernate;
using TurkiyeProvinces.DataAccess.Concrete.NHibernate.Mappings;

namespace TurkiyeProvinces.DataAccess.Concrete.NHibernate.Helpers;

public class SqlServerHelper : NHibernateHelper
{
    protected override ISessionFactory InitiliazeFactory()
    {
        return Fluently.Configure()
            .Database(MySQLConfiguration.Standard.ConnectionString(
                c => c.Server("localhost")
                    .Database("provinces")
                    .Username("root")
                    .Password("12345678")))
            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<CityMap>())
            .BuildSessionFactory();
    }
}