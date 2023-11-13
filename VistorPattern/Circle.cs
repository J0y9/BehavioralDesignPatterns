// ConcreteElement: Circle
namespace VistorPattern;

public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitCircle(this);
    }
}