namespace DesignPatterns.Behavorial.Observer;

public interface IObserver
{
    void Update(string message);
}

public class NewsChannel : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"Received news: {message}");
    }
}

public class NewsAgency
{
    private List<IObserver> observers = new List<IObserver>();

    public void Subscribe(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }
}