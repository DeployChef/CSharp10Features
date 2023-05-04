# Lambdas improvements

C# 10 includes many improvements in the handling of lambda expressions:

1. Lambda expressions can have a natural type if the compiler can infer the delegate type from the lambda expression or method group.
1. Lambda expressions can declare a return type when the compiler can't infer it.
1. Attributes can be applied to lambda expressions.

These functions make lambda expressions more like methods and local functions. They make it easier to use lambda expressions without declaring a delegate type variable and work more efficiently with the new ASP.NET Core minimal APIs.

```csharp
Func<string> oldLambda = () => "Hello!";

var newLambda = () => "Hello!";
var newLambdaNull = string? () => null;
```

