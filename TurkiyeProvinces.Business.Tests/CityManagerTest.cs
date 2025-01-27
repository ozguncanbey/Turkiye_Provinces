using Moq;
using TurkiyeProvinces.Business.Concrete.Managers;
using TurkiyeProvinces.DataAccess.Abstract;
using TurkiyeProvinces.Entities.Concrete;

namespace TurkiyeProvinces.Business.Tests;

[TestFixture]
public class CityManagerTest
{
    [Test]
    public void City_validation_test()
    {
        Mock<ICityDal> mock = new Mock<ICityDal>();
        
        CityManager cityManager = new CityManager(mock.Object);
        
        cityManager.Add(new City());
    }
}