public interface IPeopleRepository
{
    Person Read(int personId);
}

public interface ILogger
{
    void Log(Exception ex);
}

public class PersonDataReader(
    IPeopleRepository personRepository,
    ILogger logger)
{
    private readonly IPeopleRepository _peopleRepository = personRepository;
    private readonly ILogger _logger = logger;

    public Person ReadPersonData(int personId)
    {
        try
        {
            return _peopleRepository.Read(personId);
        }
        catch (Exception ex)
        {
            _logger.Log(ex);
            throw;
        }
    }
}

