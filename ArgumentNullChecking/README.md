# Argument Nulll Checking

## C# 9

```csharp
if (text is null)
{
    throw new ArgumentNullException(nameof(text));
}
```

## C# 10

```csharp
ArgumentNullException.ThrowIfNull(text);
```