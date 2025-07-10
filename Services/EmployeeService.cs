public class EmployeeService: IEmployeeService
{
    private readonly IPersonRepository _personRepoisitory;
    private readonly IProfileRepository _profileRepoisitory;
    public EmployeeService(IPersonRepository personRepository, IProfileRepository profileRepository)
    {
        _personRepoisitory = personRepository;
        _profileRepoisitory = profileRepository;
    }
    public List<Person> GetEmployees()
    {
        var output = _personRepoisitory.GetPersons();
        return output; 
    }
}