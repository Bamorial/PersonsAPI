public interface IPersonRepository
{
    public List<Person> GetPersons();
    public List<Person> GetPersonById(int id);
    public void PostPerson(Person person);
    public void PutPerson(int id, Person person);
    public void DeletePerson(int id);
}