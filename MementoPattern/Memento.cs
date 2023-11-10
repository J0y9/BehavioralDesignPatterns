namespace MementoPattern;

//The object that stores the state of the Originator.
public class Memento
{
    public string State { get; }

    public Memento(string state)
    {
        State = state;
    }
}