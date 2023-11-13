namespace VistorPattern;
// ConcreteVisitor: AreaCalculator
public class AreaCalculator : IVisitor
{
    public void VisitCircle(Circle circle)
    {
        double area = Math.PI * Math.Pow(circle.Radius, 2);
        Console.WriteLine($"Area of Circle with radius {circle.Radius}: {area}");
    }

    public void VisitRectangle(Rectangle rectangle)
    {
        double area = rectangle.Width * rectangle.Height;
        Console.WriteLine($"Area of Rectangle with width {rectangle.Width} and height {rectangle.Height}: {area}");
    }
}