namespace SolidPlayground.ISP;

public interface IWorkable
{
    void Work();
}

public interface IFeedable
{
    void Eat();
}

public interface ISleepable
{
    void Sleep();
}

public class Human: IWorkable, IFeedable, ISleepable
{
  public void Work()
  {
    Console.WriteLine("Work huuumaaan...");
  }

  public void Eat()
  {
    Console.WriteLine("Eat gop gop");
  }

  public void Sleep()
  {
    Console.WriteLine("Zzzzz...");
  }
}

public class Robot: IWorkable
{
  public void Work()
  {
    Console.WriteLine("Robot working...");
  }
}
