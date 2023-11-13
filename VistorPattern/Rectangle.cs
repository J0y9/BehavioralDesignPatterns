namespace VistorPattern;

// ConcreteElement: Rectangle
public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitRectangle(this);
    }
}