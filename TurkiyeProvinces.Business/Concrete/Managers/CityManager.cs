using TurkiyeProvinces.Business.Abstract;
using TurkiyeProvinces.DataAccess.Abstract;
using TurkiyeProvinces.Entities.Concrete;

namespace TurkiyeProvinces.Business.Concrete.Managers;

public class CityManager : ICityService
{
    private ICityDal _cityDal;

    public CityManager(ICityDal cityDal)
    {
        _cityDal = cityDal;
    }

    public List<City> GetAll()
    {
        return _cityDal.GetAll();
    }

    public City GetById(int id)
    {
        return _cityDal.GetById(id);
    }

    public void Add(City city)
    {
        _cityDal.Add(city);
    }

    public void Update(City city)
    {
        _cityDal.Update(city);
    }

    public void Delete(City city)
    {
        _cityDal.Delete(city);
    }
}