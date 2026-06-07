---
categories: Notes
date: 2026-06-06T10:34:00
---
**Topic:** Creational & Behavioral Design Patterns in C#

# Creational
## Factory Method Pattern
> Defines an interface for creating objects, but lets subclasses decide which class to instantiate. 
> Promotes loose coupling between creators and concrete products.

### Why Factory?
factory sits between `main` method and other classes.
main culprit: new keyword
if i instantiate an object from `main` method and if i need to change anything such as the object/interface, i have to modify the main class directly.
Now, if we use and abstract layer: factory; we just have to modify the factory instead of modifying the `main` class

**Example:** Imagine a logistics application. You simply request a "Transport" vehicle. The factory decides whether to provide a "Truck" (for road) or a "Ship" (for sea) based on the delivery route, shielding your main code from the details of creating specific vehicles.

## Abstract Factory Method Pattern
> Provides an interface for creating families of related or dependent objects without specifying their concrete classes.
> Ideal for UI toolkits, platform-specific components, and themed systems.

### Why Abstract Factory?
When you have multiple related products that need to be created together, the Abstract Factory ensures that they are compatible with each other. It abstracts away the details of which specific classes are being instantiated, allowing you to work with interfaces rather than concrete implementations.

**Example:** Think of a furniture shop. There is a "Modern Furniture Factory" and a "Victorian Furniture Factory". Both produce a Chair, a Sofa, and a Table. Using an Abstract Factory ensures that if you request furniture from the modern factory, all the pieces you get will inherently match the same modern style without you having to manually specify the style for each individual piece.

## Builder Pattern
> Separates the construction of a complex object from its representation. Uses a fluent interface to configure properties step-by-step before building the final immutable object.

Used in many places in ASP.NET
The Builder pattern eliminates telescoping constructors and makes object creation readable and maintainable.

### Why Builder?
When you have a complex object with many optional parameters, using a builder allows you to construct it in a clear and flexible way. It prevents the need for multiple constructors with different parameter combinations (the "telescoping constructor" problem) and makes the code more readable by allowing you to specify only the parameters you care about in a fluent manner.

**Example:** Ordering a custom house. Instead of passing 20 different parameters to a constructor at once (number of windows, doors, roof type, pool, garage, etc.), you use a builder to configure it step-by-step: `Builder.AddWindows(4).BuildRoof("Gable").AddPool().BuildHouse()`. This is much easier to read and prevents passing wrong arguments to the wrong parameters.

# Behavioral
## Observer Pattern
> Defines a one-to-many dependency between objects. When one object changes state, all its dependents are notified automatically.

### Why Observer?
The Observer pattern promotes loose coupling between the subject and its observers. The subject doesn't need to know anything about the observers; it simply maintains a list of them and notifies them of changes. This allows for dynamic relationships between objects and makes it easy to add or remove observers without modifying the subject's code. It is particularly useful in scenarios where you want to implement event-driven systems or when multiple components need to react to changes in a shared state without tightly coupling their implementations.

**Example:** A newsletter subscription. You (the observer) subscribe to a publisher (the subject). You don't have to check their website every day to see if there is news; instead, as soon as a new edition is published, the publisher automatically sends it out to all of its active subscribers.


## Strategy Pattern
> Defines a family of algorithms, encapsulates each one, and makes them interchangeable. The client can swap strategies at runtime without modifying the context class.

### Why Strategy?
The Strategy pattern allows you to define a family of algorithms, encapsulate each one, and make them interchangeable. This gives you the flexibility to choose the appropriate algorithm at runtime based on the specific requirements of the situation.

**Example:** A navigation app like Google Maps. When you need directions from Point A to Point B, you can easily switch your travel mode (the strategy) from "Walking" to "Driving" to "Public Transit". The app calculates the route differently depending on the active strategy, but your interaction with the map remains the same
