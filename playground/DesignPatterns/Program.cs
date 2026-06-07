using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.AbstractFactoryMethod;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Behavorial.Observer;
using DesignPatterns.Behavorial.Strategy;

namespace DesignPatterns;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a factory for email notifications
        Console.WriteLine("Factory Method Pattern:");
        NotificationFactory emailFactory = new EmailFactory();
        INotification emailNotification = emailFactory.CreateNotification();
        emailNotification.Notify();

        // Create an abstract factory for Windows UI components
        Console.WriteLine("\nAbstract Factory Method Pattern:");
        IGUIFactory winFactory = new WinFactory();
        IButton winButton = winFactory.CreateButton();
        winButton.Paint();

        ICheckbox winCheckbox = winFactory.CreateCheckbox();
        winCheckbox.Paint();

        IGUIFactory macFactory = new MacFactory();
        IButton macButton = macFactory.CreateButton();
        macButton.Paint();

        ICheckbox macCheckbox = macFactory.CreateCheckbox();
        macCheckbox.Paint();


        // Builder pattern example
        Console.WriteLine("\nBuilder Pattern:");
        var computer = new Computer.Builder()
            .SetCPU("Ryzen 7")
            .SetRAM(16)
            .SetStorage(512)
            .SetGPU(false)
            .Build();

        Console.WriteLine("\nBuilt Computer with Builder Pattern:");
        Console.WriteLine(computer);

        Computer ComputerWithoutBuilder = new Computer("Ryzen 7", 16, 512, false);
        Console.WriteLine("\nBuilt Computer without Builder Pattern:");
        Console.WriteLine(ComputerWithoutBuilder);


        // Observer pattern example
        Console.WriteLine("\nObserver Pattern:");
        NewsAgency agency = new NewsAgency();
        NewsChannel channel1 = new NewsChannel();
        NewsChannel channel2 = new NewsChannel();
        NewsChannel channel3 = new NewsChannel();

        agency.Subscribe(channel1);
        agency.Subscribe(channel2);
        agency.Subscribe(channel3);

        agency.Notify("Breaking News: Design Patterns in C#!");

        agency.Unsubscribe(channel2);

        agency.Notify("Update: Observer Pattern Demonstrated!");


        // Strategy pattern example
        Console.WriteLine("\nStrategy Pattern:");
        ShoppingCart cart = new ShoppingCart();
        cart.SetPaymentStrategy(new CreditCardPayment());
        cart.Checkout(100);

        cart.SetPaymentStrategy(new PayPalPayment());
        cart.Checkout(200);
    }
}