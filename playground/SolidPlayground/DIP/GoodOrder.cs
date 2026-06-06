namespace SolidPlayground.DIP;

public class GoodOrder
{
    private readonly IDatabase _database;

    public GoodOrder(IDatabase database)
    {
        _database = database;   // Dependency Injection through constructor
    }

    public void SaveOrder(GoodOrder order)
    {
        _database.SaveOrder(order);
    }
}

public interface IDatabase
{
    void SaveOrder(GoodOrder order);
}

public class Sql : IDatabase
{
    public void SaveOrder(GoodOrder order)
    {
        Console.WriteLine("Order saved to SQL Database");
    }
}


public class Mongo : IDatabase
{
    public void SaveOrder(GoodOrder order)
    {
        Console.WriteLine("Order saved to Mongo Database");
    }
}
