# Record struct

Now we can declare value type records using the record struct or readonly record struct declarations. You can now clarify that a record is a reference type with the record class declaration.

```csharp
public record class Person(string FirstName, string LastName);

public readonly record struct Client(string FirstName, string LastName);
```

