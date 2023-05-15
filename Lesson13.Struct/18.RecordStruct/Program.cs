Point p1 = new Point() { X = 100, Y = 100 };
Point p2 = new Point() { X = 100, Y = 100 };

Console.WriteLine(p1 == p2);
Console.WriteLine(p1.GetHashCode() == p2.GetHashCode());

public record struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}