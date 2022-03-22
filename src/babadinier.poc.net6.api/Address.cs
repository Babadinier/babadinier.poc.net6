namespace babadinier.poc.net6.api;

public class Address
{
    public string Number { get; init; }
    public string Name { get; init; }

    public Address(string number, string name)
    {
        Number = number;
        Name = name;
    }
}