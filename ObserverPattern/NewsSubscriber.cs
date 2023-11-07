namespace ObserverPattern;

public class NewsSubscriber : IObserver
{
    public void Update()
    {
        Console.WriteLine("Subscriber Notified");
    }
}