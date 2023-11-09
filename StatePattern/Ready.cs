namespace StatePattern;

public class Ready : IState
{
    
    
    public  void InsertMoney()
    {
        Console.WriteLine("Money inserted");
    }

    public  void SelectItem()
    {
        Console.WriteLine("Insert Money First");
    }

    public  void DispenseItem()
    {
        Console.WriteLine("Insert Money Then Select Item ");
    }

}