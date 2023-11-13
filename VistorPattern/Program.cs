
using VistorPattern;

List<IShape> shapes = new ()
{
    new Circle(5),
    new Rectangle(4, 6)
};

AreaCalculator areaCalculator = new ();
PerimeterCalculator perimeterCalculator = new ();

foreach (var shape in shapes)
{
    shape.Accept(areaCalculator);
    shape.Accept(perimeterCalculator);
}
