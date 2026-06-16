using AdvancedRuntimeAndDecoupling.Delegates;

Console.WriteLine("Action Delegate: ");
var publisher = new NewsPublisher();
publisher.NewsPublished += msg => Console.WriteLine($"Email sent: {msg}");

publisher.Publish("C# Class Started!");

//
Console.WriteLine("\nFunc delegate: ");
List<int> numbers = new List<int> { 1, 2, 3 };
Map map = new Map();
// Pass the lambda expression. C# knows it takes an int and returns an int!
List<int> doubled = Map.MapList(numbers, x => x * 2);

Console.WriteLine(string.Join(", ", doubled)); // Outputs: 2, 4, 6
