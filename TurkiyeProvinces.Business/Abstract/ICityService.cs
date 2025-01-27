using TurkiyeProvinces.Entities.Concrete;

namespace TurkiyeProvinces.Business.Abstract;

public interface ICityService
{
    List<City> GetAll();
    void GetById(int id);
    void Add(City city);
    void Update(City city);
    void Delete(City city);
}