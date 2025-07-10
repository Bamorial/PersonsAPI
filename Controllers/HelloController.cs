using Microsoft.AspNetCore.Mvc;

namespace PersonsApi.Controllers  
{
    public class HelloController : ControllerBase
    {
        [HttpGet("hello_world")] 
        public IActionResult Get()
        {
            return Ok("Hello world from controller");
        }
        [HttpPost("hello_world")] 
        public IActionResult Post()
        {
            return Ok("Post from controller");
        }
    }
}
