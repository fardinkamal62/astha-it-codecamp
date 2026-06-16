namespace AdvancedRuntimeAndDecoupling.Delegates;

// Using Action here
public class NewsPublisher
{
    public event Action<string>? NewsPublished;

    public void Publish(string news)
    {
        Console.WriteLine("Publishinig: " + news);

        NewsPublished?.Invoke(news);
    }
}
