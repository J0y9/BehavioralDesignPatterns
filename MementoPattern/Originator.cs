namespace MementoPattern;

//The object whose state needs to be saved.
public class Originator
{
    public string State { get; set; } = string.Empty;
    
    public Memento SaveState()
    {
        return new Memento(State);
    }
    public void RestoreState(Memento memento)
    {
        State = memento.State;
    }

}