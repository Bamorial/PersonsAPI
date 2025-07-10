
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;

namespace PersonsApi.Controllers
{
    [ApiController]
    [Route("persons/v1")]

    public class PersonsController : ControllerBase
    {
        private IPersonRepository _personRepository;
        public PersonsController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        List<Person> persons = new()
        {
    new Person
        {
            Id=1,
            Email = "john.doe@example.com",
            Profile = new Profile
            {
                Age = 32,
                Company = "Acme Corp",
                Name = "John Doe"
            }
        },
        new Person
        {
            Id=2,
            Email = "jane.smith@example.com",
            Profile = new Profile
            {
                Age = 28,
                Company = "Globex Inc.",
                Name = "Jane Smith"
            }
        },
        new Person
        {
            Id=3,
            Email = "michael.brown@example.com",
            Profile = new Profile
            {
                Age = 45,
                Company = "Umbrella Group",
                Name = "Michael Brown"
            }
        },
        new Person
        {
            Id=4,
            Email = "lucy.wilson@example.com",
            Profile = new Profile
            {
                Age = 37,
                Company = "Stark Industries",
                Name = "Lucy Wilson"
            }
        },
        new Person
        {
            Id=5,
            Email = "david.johnson@example.com",
            Profile = new Profile
            {
                Age = 29,
                Company = "Wayne Enterprises",
                Name = "David Johnson"
            }
        }
        };
        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            return Ok(_personRepository.GetPersons());
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute]int id)
        {
            return Ok(_personRepository.GetPersonById(id));
        }
        [HttpGet]
        public IActionResult GetPage([FromQuery] int per_page, [FromQuery] int page)
        {
            return Ok(persons.Paginate<Person>(per_page, page));
        }
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            _personRepository.PostPerson(person);
            return Ok(person);
        }
        [HttpPut]
        public IActionResult Put( [FromBody] Person person)
        {
            _personRepository.PutPerson(person.Id, person);
            return Ok(person);
        }
        [HttpDelete]
        public IActionResult Delete([FromQuery] int id )
        {
            _personRepository.DeletePerson(id);
            return Ok();
        }
    }
}