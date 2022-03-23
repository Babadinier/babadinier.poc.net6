namespace babadinier.poc.net6.api;

public class Person
{
    private readonly List<Person> children;

    public string LastName { get; init; }
    public string FirstName { get; private set; }
    public Address Address { get; private set; }
    public List<Person> Children => children;

    public Person(string lastName, string firstName, Address address)
    {
        LastName = string.IsNullOrWhiteSpace(lastName) ? throw new ArgumentNullException(nameof(lastName)) : lastName;
        FirstName = string.IsNullOrWhiteSpace(firstName) ? throw new ArgumentNullException(nameof(firstName)) : firstName;;
        Address = address is null ? throw new ArgumentNullException(nameof(address)) : address;
        children = new();
    }

    public void AddChild(Person child)
    {
        ArgumentNullException.ThrowIfNull(child);  
        children.Add(child);
    }

    public void UpdateFirstName(string firstName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
        {
            throw new ArgumentNullException(nameof(firstName));
        }
        FirstName = firstName;
    }
}