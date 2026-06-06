---
tags:
  - Notes
date: 2026-06-04T17:00:00
---
**Topic**: Applying SOLID Principles in OOP Design

Object Oriented Programming is giving us relationship; relationship between objects.
But we don't know what kind of relation is better, what kind of relation doesn't work

SOLID was introduced by Robert C. Martin (Uncle Bob)
Intended to make the software more understandable, flexible and maintainable

5 principles of SOLID:
1. Single Responsibility Principle (SRP)
2. Open/Closed Principle(ORP)
3. Liskov Substitution Principle(LSP)
4. Interface Segregation Principle (ISP)
5. Dependency Inversion Principle (DIP)

We can't just build software writing in unstructured way- we have to think about design, structure. This is where SOLID principles come.

Each principle addresses a specific design concern, helping developers avoid common pitfalls like tightly coupled code, fragile hierarchies and bloated classes 


Other principles for SOLID: DRY, YAGNI

## Single Responsibility Principle(SRP):
> a class should have only one reason to change, each class should be responsible for a single, well-defined piece of functionality 

One class will only carry one single responsibility; not more than one.
Bad practice if one class does more than one thing.

### Why?
Having multiple responsibilities means the class is more likely to need changes for different reasons. Modifying one responsibility could accidentally introduce bugs into another. Keeping them separate makes the code easier to understand, test, and maintain, preventing the creation of fragile "God Objects."

## Open/Closed Principle (OCP)
> Software entities should be open for extension but closed for modification. Add new behavior without changing existing code.

Open- extendable
Closed- without changing the existing code

### Why?
Because modifying existing, well-tested code risks introducing new bugs into a working system. By extending instead of modifying, we add new functionality safely without breaking existing dependencies. It minimizes the need to re-test existing functionality and makes the system stable yet adaptable.

## Liskov Substitution Principle (LSP)
> Objects of a superclass shall be replaceable with objects of subclasses without affecting correctness. Derived classes must be substitutable for their base classes.

We should be able to replace sub class object with parent class object- without affecting correctness

**Solution?** Segregation
Not all the the things that are connected with each other in real life, cannot be coded as connected to each other.
Example:
An **Ostrich** is a type of **Bird** but it can't fly. So if we make a Bird class and inherit Ostrich class from it, it can't _fly_ 

Inheritance tightly couples a codebase: due to "is-a" relationship
Interface loosely couples a codebase

### Why?
If a subclass violates this principle (e.g., throwing a `NotImplementedException` for an inherited method), any code expecting the base class might crash or behave unpredictably. LSP ensures that polymorphism works correctly and reliably, preventing runtime errors when seamlessly using derived classes.

## Interface Segregation Principle (ISP)
> Clients should not be forced to depend on interfaces they do not use. Split large interfaces into smaller, focused ones.

### Why?
Forcing a class to implement methods it doesn't need leads to bloated code and dummy implementations (which often violate LSP). Small, role-specific interfaces ensure that implementing classes only depend on what they actually use, resulting in a cleaner, decoupled, and highly modular design.

## Dependency Inversion Principle (DIP)
> High-level modules should not depend on low-level modules; both should depend on abstractions.
Depend on abstractions, not concretions.

ASP.net uses it heavily
Dependency Injection(DI) is built on top of Dependency Inversion Principle

### Why?
High-level modules contain the core business logic. If they depend directly on low-level infrastructure (like a specific database, file system, or API), any change in those details impacts the core logic. Abstractions decouple the two, making the system highly flexible, easier to maintain, and much easier to unit test (via mock objects).
No one will be dependent on anyone. Everyone will be depended on abstraction(interface)
