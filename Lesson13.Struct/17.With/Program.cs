Point point = new Point() { x = 10, y = 10 };
Point newPoint = point with { x = 20 };
Console.WriteLine(newPoint);

struct Point
{
    public int x;
    public int y;

    public override string ToString()
    {
        return $"x={x}, y={y}";
    }
}