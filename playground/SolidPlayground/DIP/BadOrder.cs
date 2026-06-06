namespace SolidPlayground.DIP.Bad;

public class BadOrder
{
    private readonly SqlDatabase _database;

    public BadOrder()
    {
        _database = new SqlDatabase();  // Tight coupling to a specific database implementation
    }

    public void Save(BadOrder order)
    {
        _database.SaveOrder(order);
    }
}

public class SqlDatabase    // Low level module that directly depends on a specific database implementation
{
    public void SaveOrder(BadOrder order)
    {
        Console.WriteLine("Order saved to SQL Database");
    }
}

public class Order
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
}
