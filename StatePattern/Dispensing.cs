namespace StatePattern;

public class Dispensing : IState
{


    public  void InsertMoney()
    {
        Console.WriteLine("Money already inserted");
    }

    public  void SelectItem()
    {
        Console.WriteLine("Item already selected");
    }

    public  void DispenseItem()
    {
        Console.WriteLine("Dispensing Item");
    }
}