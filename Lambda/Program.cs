namespace Lambda;

public class Program
{
    public void Main()
    {
        Func<string> helloOldWorld = () => "Hello!";

        var helloNewWorld = () => "Hello!";
        var helloNull = string? () => null;
    }
}