# File scoped namespaces

Now we can use a new form of the namespace declaration to declare that all declarations that follow are members of the declared namespace

```csharp
namespace MyNamespace;

public class FileScopedNamespace
{
    public void Program()
    {
        Console.WriteLine("Hello world");
    }
}
```

