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
                "Tony Stark"
            };
           return Ok(persons);
        }
    }
}