namespace RecordStructs;

public record class Person(string FirstName, string LastName);
public readonly record struct Client(string FirstName, string LastName);

public class Example
{
    public void Main()
    {
        var person = new Person("Person", "Person");
        var client = new Client("Client", "Client");
    }
}
