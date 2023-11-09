namespace StatePattern;

public class Selecting : IState
{
    public void InsertMoney()
    {
        Console.WriteLine("Money already inserted");

    }

    public void SelectItem()
    {
        Console.WriteLine("Item Selected");
    }

    public void DispenseItem()
    {
        Console.WriteLine("Select Item First");
    }
}