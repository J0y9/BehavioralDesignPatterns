namespace StrategyPattern;

public class CreditCard: IPayment
{
    public void Pay()
    {
        Console.WriteLine("Paying using CreditCard");
    }
}