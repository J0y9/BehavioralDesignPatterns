namespace VistorPattern;

// ConcreteVisitor: PerimeterCalculator
public class PerimeterCalculator : IVisitor
{
    public void VisitCircle(Circle circle)
    {
        double perimeter = 2 * Math.PI * circle.Radius;
        Console.WriteLine($"Perimeter of Circle with radius {circle.Radius}: {perimeter}");
    }

    public void VisitRectangle(Rectangle rectangle)
    {
        double perimeter = 2 * (rectangle.Width + rectangle.Height);
        Console.WriteLine($"Perimeter of Rectangle with width {rectangle.Width} and height {rectangle.Height}: {perimeter}");
    }
}