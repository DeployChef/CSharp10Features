# Deconstruction declaration

Now you can declare variables directly as a result of deconstructor output

```csharp
var point = new Point(5, 8, 2);

int y = 0;

(int x, y, string z) = point;
```