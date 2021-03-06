using Microsoft.AspNetCore.Mvc;

namespace babadinier.poc.net6.api.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonsController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;

    public PersonsController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Person> Get()
    {
        var gilbert = new Person("Gilbert", "Bertrand", new Address("42", "Emile Zola"));
        gilbert.AddChild(new Person("Robert", "Didier", new Address("42", "Emile Zola")));

        return new List<Person> { 
            gilbert
        };
    }
}
