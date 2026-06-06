using SolidPlayground.ISP;
using SolidPlayground.LSP;
using SolidPlayground.OCP;
using SolidPlayground.OCP.Bad;
using SolidPlayground.SRP;

// Bad SRP
Console.WriteLine("Bad SRP Example:");
var badEmployee = new Employee();

badEmployee.Name = "John Doe";
badEmployee.Salary = 50000;

Console.WriteLine(badEmployee);

// Good SRP
Console.WriteLine("\nGood SRP Example:");
var goodEmployee = new GoodEmployee();

goodEmployee.Name = "Jane Doe";
goodEmployee.Salary = 60000;

var repository = new EmployeeRepository();
repository.SaveToDatabase(goodEmployee);

var reportGenerator = new EmployeeReportGenerator();
reportGenerator.GenerateReport(goodEmployee);

var emailService = new EmployeeEmailService();
emailService.SendEmail(goodEmployee);

// Bad OCP
Console.WriteLine("\nBad OCP Example:");
var badAreaCalculator = new BadAreaCalculator();
var rectangle = new SolidPlayground.OCP.Bad.Rectangle { Width = 5, Height = 10 };
var circle = new SolidPlayground.OCP.Bad.Circle { Radius = 7 };

Console.WriteLine($"Area of Rectangle: {badAreaCalculator.CalculateArea(rectangle)}");
Console.WriteLine($"Area of Circle: {badAreaCalculator.CalculateArea(circle)}");

// Good OCP
Console.WriteLine("\nGood OCP Example:");
var goodAreaCalculator = new GoodAreaCalculator();
var goodRectangle = new SolidPlayground.OCP.Rectangle { Width = 5, Height = 10 };
var goodCircle = new SolidPlayground.OCP.Circle { Radius = 7 };

Console.WriteLine($"Area of Rectangle: {goodAreaCalculator.CalculateArea(goodRectangle)}");
Console.WriteLine($"Area of Circle: {goodAreaCalculator.CalculateArea(goodCircle)}");

// Bad LSP
Console.WriteLine("\nBad LSP Example");
var ostrich = new SolidPlayground.LSP.Bad.Ostrich();
Console.WriteLine("Throws an exception as Ostrich can't fly");

// ostrich.Fly(); // Throws an exception

// Good LSP
Console.WriteLine("\nGood LSP Example");
var goodBird = new GoodBird();
var sparrow = new Sparrow();
Ostrich ostrich1 = new Ostrich();

goodBird.MakeBirdFly(sparrow);
goodBird.MakeBirdRun(ostrich1);

// Bad ISP
Console.WriteLine("\nBad ISP Example");
SolidPlayground.ISP.Bad.Robot robot = new SolidPlayground.ISP.Bad.Robot();
// robot.Eat(); // Exception: Robots don't eat


// Good ISP
Console.WriteLine("\nGood ISP Example");
var human = new Human();
human.Work();
human.Eat();
human.Sleep();

Console.WriteLine("------------------------------");

SolidPlayground.ISP.Robot robot1 = new SolidPlayground.ISP.Robot();
robot1.Work();


// Bad DIP
Console.WriteLine("\nBad DIP Example");
var badOrder = new SolidPlayground.DIP.Bad.BadOrder();
badOrder.Save(new SolidPlayground.DIP.Bad.BadOrder());

// Good DIP
Console.WriteLine("\nGood DIP Example");
var goodOrder = new SolidPlayground.DIP.GoodOrder(new SolidPlayground.DIP.Sql());
goodOrder.SaveOrder(new SolidPlayground.DIP.GoodOrder(new SolidPlayground.DIP.Sql()));
