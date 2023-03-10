namespace GlobalUsings;

internal class Program
{
    public static void Main(string[] args)
    {
        var names = new { Hello = "Hello", World = "World" };
        var serialized = JsonSerializer.Serialize(names);

        Console.WriteLine(serialized);
    }
}


