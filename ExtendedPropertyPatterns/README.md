# Extended property patterns

Now we can reference nested properties or fields within a property pattern.

## C#9
```csharp
if (company is { SubCompany: { Department: { Team:TeamLead: {Name: "Leader"}}}}})
{
    // ...
}
```
## C#10
```csharp
if (company is { SubCompany.Department.Team.TeamLead.Name: "Leader" })
{
    // ...
}
```

