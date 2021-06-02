using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var persons = new string[]{
                "Mohamad",
                "Donald duck",
                "Mickey",
                "Batman",
                "Thor",
                "Tony Stark",
                "Mercedes",
                "BMW",
                "Jeep",
                "Honda",
                "Ferrari", 
                "Lambo",
                "Renault"
            };
           return Ok(persons);
        }
    }
}