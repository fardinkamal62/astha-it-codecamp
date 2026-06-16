namespace AdvancedRuntimeAndDecoupling.Delegates;

using System.Collections.Generic;

class Map
{
    // Custom method that acts like JS .map()
    // It takes a list and a Func delegate that maps an int to an int
    public static List<int> MapList(List<int> source, Func<int, int> transformer)
    {
        List<int> result = new List<int>();
        foreach (var item in source)
        {
            // We execute the callback and capture the returned value in a variable!
            int transformedValue = transformer(item);
            result.Add(transformedValue);
        }
        return result;
    }
}
