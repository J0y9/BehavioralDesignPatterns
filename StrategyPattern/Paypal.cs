namespace StrategyPattern;

public class Paypal : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Paying using Paypal");
    }
}