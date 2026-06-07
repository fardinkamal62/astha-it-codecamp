namespace DesignPatterns.Creational.AbstractFactoryMethod;

public interface IButton
{
    void Paint();
}

public interface ICheckbox
{
    void Paint();
}

public class WinButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("You have created a WinButton.");
    }
}

public class WinCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("You have created a WinCheckbox.");
    }
}

public class MacButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("You have created a MacButton.");
    }
}

public class MacCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("You have created a MacCheckbox.");
    }
}


public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}

public class WinFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new WinButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WinCheckbox();
    }
}

public class MacFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacCheckbox();
    }
}