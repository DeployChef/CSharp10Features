namespace Lambda;

public class Program
{
    public void Main()
    {
        Func<string> oldLambda = () => "Hello!";

        var newLambda = () => "Hello!";
        var newLambdaNull = string? () => null;
    }
}