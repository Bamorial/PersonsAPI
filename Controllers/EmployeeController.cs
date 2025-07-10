
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;

namespace PersonsApi.Controllers
{
    [ApiController]
    [Route("employee/v1")]

    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            return Ok(_employeeService.GetEmployees());
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute]int id)
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult Put( [FromBody] Person person)
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete([FromQuery] int id )
        {
            return Ok();
        }
    }
}