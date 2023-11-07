namespace ObserverPattern;

public class NewsPublisher: Subject
{
    public void PublishNews(string news)
    {
        Console.WriteLine(news);
        NotifyObservers();
    }
}