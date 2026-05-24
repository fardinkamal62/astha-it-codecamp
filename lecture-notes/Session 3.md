---
tags:
  - Notes
date: 2026-05-13T21:15:00
---
**Topic:** Abstraction, Polymorphism, Interfaces, and Object Relationships

# Inheritance
_inheritance_ "is- a" relationship
Inheritance is loosely coupled


**Example**
Bad: Inheritance:
```cs
public class EmailNotifier
{
	public void Send() { }
}
public class SmsNotifier : EmailNotifier { }
// Forced inheritance
```


_Composition_  is "Has- a" relationship

# Polymorphism
বহুরুপ

two types:
1. compile time: method overloading
2. runtime- method override

