namespace SolidPlayground.LSP;

public class GoodBird
{
    public void MakeBirdFly(IFlyable flyable)
    {
        flyable.Fly();
    }

    public void MakeBirdRun(IRunnable runnable)
    {
        runnable.Run();
    }
}

public interface IFlyable
{
    void Fly();
}

public interface IRunnable
{
    void Run();
}

public class Sparrow : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("The Sparrow is flyyiinnggg...");
    }
}

public class Ostrich : IRunnable
{
    public void Run()
    {
        Console.WriteLine("The Ostrich is runninnnnggg...");
    }
}
