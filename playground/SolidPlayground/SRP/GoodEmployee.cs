namespace SolidPlayground.SRP;

public class GoodEmployee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
}

public class EmployeeRepository
{
    public void SaveToDatabase(GoodEmployee e)
    {
        Console.WriteLine("Saving to database...");
    }
}

public class EmployeeReportGenerator
{
    public void GenerateReport(GoodEmployee e)
    {
        Console.WriteLine("Generating report...");
    }
}

public class EmployeeEmailService
{
    public void SendEmail(GoodEmployee e)
    {
        Console.WriteLine("Sending email...");
    }
}
