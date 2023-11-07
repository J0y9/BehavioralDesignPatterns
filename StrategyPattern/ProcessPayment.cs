namespace StrategyPattern;

public class ProcessPayment
{
    private readonly IPayment _payment;

    public ProcessPayment(IPayment payment)
    {
        _payment = payment;
    }

    public void Pay()
    {
        _payment.Pay();
    }
}