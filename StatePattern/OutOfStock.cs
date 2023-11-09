namespace StatePattern;

public class OutOfStock : IState
{


    public  void InsertMoney()
    {
        Console.WriteLine("Out of stock");
    }

    public  void SelectItem()
    {
        Console.WriteLine("Out of stock");

    }

    public  void DispenseItem()
    {
        Console.WriteLine("Out of stock");

    }
}