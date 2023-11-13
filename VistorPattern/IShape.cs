namespace VistorPattern;

public interface IShape
{
    void Accept(IVisitor visitor);
}