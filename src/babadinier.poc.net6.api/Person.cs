namespace babadinier.poc.net6.api;

public class Person
{
    private readonly List<Person> children;

    public string LastName { get; init; }
    public string FirstName { get; init; }
    public List<Person> Children => children;

    public Person(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
        children = new();
    }

    public void AddChild(Person child)
    {
        if (child is null)
        {
            throw new ArgumentNullException(nameof(child));
        }
        children.Add(child);
    }
}