# Record seal to string

In C# 10, you can add a compaction modifier when overriding ToString for a record type. 

Sealing the ToString method prevents the compiler from synthesizing a ToString method for any derived record types.

 The sealed ToString ensures that all derived record types use the ToString method defined for the common base record type. You can learn more about this feature in the posts article.

```csharp
public record Parent(string FirstName, string LastName)
{
    public sealed override string ToString()
    {
        return $"Hi my name is: {FirstName} {LastName}";
    }
}

public record Child(string FirstName, string LastName, string Phone)
        : Parent(FirstName, LastName)
{
    //Невозможно оверрайдить при sealed
    public override string ToString()
    {
        return $"Hi my name is: {FirstName} {LastName}. Andmy Phone is: {Phone}";
    }
}
```

