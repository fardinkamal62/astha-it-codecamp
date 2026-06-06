namespace SolidPlayground.SRP;

public class Employee
{
    public string Name { get; set; } = String.Empty;
    public decimal Salary { get; set; }

    /*
     * Why is it bad?
     * The Employee class has multiple responsibilities:
     * 1. It holds employee data (Name and Salary).
     * 2. It has methods to save data to a database, generate reports, and send emails.
     *
     * This violates the Single Responsibility Principle
     * because if we need to change how we save to the database, generate reports, or send emails,
     * we would have to modify the Employee class, which should ideally only be responsible for
     * managing employee data.
     */
    public void SaveToDatabase()
    {
        Console.WriteLine("Saving to database...");
    }

    public void GenerateReport()
    {
        Console.WriteLine("Generating report...");
    }

    public void SendEmail()
    {
        Console.WriteLine("Sending email...");
    }

    public override string ToString()
    {
        return $"Employee: {Name}, Salary: {Salary}";
    }
}
