using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers;

public class WeatherController : Controller
{
    [HttpGet("/")]
    public IActionResult Index()
    {
        List<Weather> cities = new List<Weather>()
        {
            new Weather()
            {
                CityUniqueCode = "LDN",
                CityName = "London",
                DateAndTime = DateTime.Parse("2030-01-01 08:00"),
                TemperatureFahrenheit = 33
            },
            new Weather()
            {
                CityUniqueCode = "NYC",
                CityName = "New York",
                DateAndTime = DateTime.Parse("2030-01-01 03:00"),
                TemperatureFahrenheit = 60
            },
            new Weather()
            {
                CityUniqueCode = "PAR",
                CityName = "Paris",
                DateAndTime = DateTime.Parse("2030-01-01 09:00"),
                TemperatureFahrenheit = 82
            }
        };

        return View(cities);
    }

    [HttpGet("/weather/{cityUniqueCode?}")]
    public IActionResult Weather(string cityUniqueCode)
    {
        List<Weather> cities = new List<Weather>()
        {
            new Weather()
            {
                CityUniqueCode = "LDN",
                CityName = "London",
                DateAndTime = DateTime.Parse("2030-01-01 08:00"),
                TemperatureFahrenheit = 33
            },
            new Weather()
            {
                CityUniqueCode = "NYC",
                CityName = "New York",
                DateAndTime = DateTime.Parse("2030-01-01 03:00"),
                TemperatureFahrenheit = 60
            },
            new Weather()
            {
                CityUniqueCode = "PAR",
                CityName = "Paris",
                DateAndTime = DateTime.Parse("2030-01-01 09:00"),
                TemperatureFahrenheit = 82
            }
        };
        if (cityUniqueCode is null)
        {
            return NotFound();
        }
        else
        {
            Weather city = cities.Where(tmp => tmp.CityUniqueCode.Equals(cityUniqueCode)).FirstOrDefault();
            return View(city);
        }
    }
}