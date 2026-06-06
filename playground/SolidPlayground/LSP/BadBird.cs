namespace SolidPlayground.LSP.Bad;

/*
 * This is a bad example of Liskov Substitution Principle
 * Here we have 2 class: Bird and Ostrich.
 * Ostrich is a subclass of Bird.
 * So by definition, Ostrich should have all the properties of a bird.
 * And if we are using Ostrich class somewhere, we should be able to replace it with Bird and it should work fine.
 * Which isn't true in this case.
*/
public class BadBird
{
    public virtual void Fly()
    {
        Console.WriteLine("Flyyiinnggg...");
    }
}

public class Ostrich : BadBird
{
    // Violation: Ostrich can't fly!
    public override void Fly()
    {
        throw new InvalidOperationException("Ostrich don't fly");
    }
}
