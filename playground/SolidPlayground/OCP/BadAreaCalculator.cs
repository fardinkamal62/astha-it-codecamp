namespace SolidPlayground.OCP.Bad;

/*
 * Bad OCP Example:
 * The BadAreaCalculator class violates the Open/Closed Principle because it requires modification to accommodate new
 * shapes. Every time a new shape is added, the CalculateArea method must be changed, which can lead to bugs and maintenance issues.
 */
public class BadAreaCalculator
{
    public double CalculateArea(object shape)
    {
        if (shape is Rectangle)
        {
            var r = (Rectangle)shape;
            return r.Width * r.Height;
        }
        else if (shape is Circle)
        {
            var c = (Circle)shape;
            return Math.PI * c.Radius * c.Radius;
        }

        // Modify for every new shape!
        return 0;
    }
}

public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
}

public class Circle
{
    public double Radius { get; set; }
}
