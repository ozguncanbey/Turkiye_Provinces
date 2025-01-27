using TurkiyeProvinces.DataAccess.Concrete.NHibernate;
using TurkiyeProvinces.DataAccess.Concrete.NHibernate.Helpers;

namespace TurkiyeProvinces.DataAccess.Tests.NHibernateTests;

[TestFixture]
public class NHibernateTest
{
    [Test]
    public void Get_all_returns_all_cities()
    {
        NhCityDal productDal = new NhCityDal(new SqlServerHelper());
        
        var result = productDal.GetAll();
        
        Assert.That(result.Count(), Is.EqualTo(81));
    }
}