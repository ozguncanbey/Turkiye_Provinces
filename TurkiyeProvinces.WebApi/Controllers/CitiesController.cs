using Microsoft.AspNetCore.Mvc;
using TurkiyeProvinces.Business.Abstract;
using TurkiyeProvinces.Entities.Concrete;

namespace TurkiyeProvinces.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CitiesController : Controller
{
    private readonly ICityService _cityManager;

    public CitiesController(ICityService cityService)
    {
        _cityManager = cityService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var cities = _cityManager.GetAll();
        if (cities == null || !cities.Any()) return NotFound("No cities found.");
        return Ok(cities);
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        var city = _cityManager.GetById(id);
        if (city == null) return NotFound($"City with id {id} not found.");
        return Ok(city);
    }

    [HttpPost]
    public IActionResult Add([FromBody] City city)
    {
        if (!ModelState.IsValid) return BadRequest("Invalid data.");
        
        _cityManager.Add(city);
        return CreatedAtAction(nameof(GetById), new { id = city.Id }, city);
    }
    
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] City city)
    {
        if (id != city.Id) return BadRequest("City ID mismatch.");

        if (!ModelState.IsValid) return BadRequest(ModelState);
            
        var existingCity = _cityManager.GetById(id);
        if (existingCity == null) return NotFound($"City with id {id} not found.");

        _cityManager.Update(city);
        return NoContent();
    }
    
    [HttpDelete("{id:int}")]
    public IActionResult Delete([FromRoute] int id)
    {
        try
        {
            var city = _cityManager.GetById(id);
            if (city == null) return NotFound($"City with id {id} not found.");

            _cityManager.Delete(city);
            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}