namespace MementoPattern;


// The object responsible for keeping track of different states (Mementos) of the Originator.
public class CareTaker
{
    public List<Memento> Mementos { get; set; } = new();
}