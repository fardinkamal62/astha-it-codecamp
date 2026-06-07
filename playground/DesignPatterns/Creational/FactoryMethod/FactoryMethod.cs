namespace DesignPatterns.Creational.FactoryMethod;

public interface INotification
{
    void Notify();
}

public class EmailNotification : INotification
{
    public void Notify()
    {
        Console.WriteLine("Sending email notification...");
    }
}

public class SMSNotification : INotification
{
    public void Notify()
    {
        Console.WriteLine("Sending SMS notification...");
    }
}


// Introduce a factory interface

public abstract class NotificationFactory
{
    public abstract INotification CreateNotification();
}

public class EmailFactory : NotificationFactory
{
    public override INotification CreateNotification()
    {
        return new EmailNotification();
    }
}
