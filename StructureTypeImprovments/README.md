# Struct type improvments

C# 10 introduces the following improvements related to structure types:

1. You can declare an instance parameterless constructor in a structure type and initialize an instance field or property at its declaration. For more information, see the Struct initialization and default values section of the Structure types article.
1. A left-hand operand of the with expression can be of any structure type or an anonymous (reference) type.

```csharp
public struct Rectangle
{
    public Rectangle()
    {
        Height = 0;
        Width = 0;
    }

    public Rectangle(int height, int width)
    {
        Height = height;
        Width = width;
    }

    public int Height { get; init; }
    public int Width { get; init; }
}


var rectangle = new Rectangle(100, 100);

var rectangleDefault = new Rectangle();

//copy with 
var rectangleCopy = rectangle with { Width = 50 };
```

