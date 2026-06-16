namespace DesignPatterns.Structural;

public class EuropeanPlug
{
    public string GetEuropeanSocket()
    {
        return "European Socket";
    }
}

public interface IUSASocket
{
    string GetUSASocket();
}

public class SocketAdapter : IUSASocket
{
    private readonly EuropeanPlug _europeanPlug;

    public SocketAdapter(EuropeanPlug europeanPlug)
    {
        _europeanPlug = europeanPlug;
    }

    public string GetUSASocket()
    {
        return $"Adapter converted: {_europeanPlug.GetEuropeanSocket()}";
    }
}

public class Laptop
{
    public void Charge(IUSASocket socket)
    {
        Console.WriteLine($"Charging using {socket.GetUSASocket()}");
    }
}
