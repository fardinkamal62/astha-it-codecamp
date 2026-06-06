namespace SolidPlayground.ISP.Bad;

public interface IWorker
{
    void Work();
    void Sleep();
    void Eat();
}

public class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Robot doing it's job");
    }

    public void Sleep()
    {
        throw new InvalidOperationException("Robots don't need sleep");
    }

    public void Eat()
    {
        throw new InvalidOperationException("Robots don't eat");
    }
}
