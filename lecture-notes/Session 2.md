---
tags:
  - Notes
date: 2026-05-10T21:00:00
---
**Topic:** Abstraction, Polymorphism, Interfaces, and Object Relationships

Today's topic: Encapsulation and Inheritance

**Pillars of OOP**
1. Encapsulation
2. Inheritance 
3. Abstraction
4. Polymorphism

# Encapsulation
**Definition:** Encapsulation is a fundamental principle of object-oriented programming that bundles data (fields) and the methods that operate on that data into a single unit (class), while restricting direct access to some components.

	behavior and data both ekta class er moddhe capsule e capture kortese

Benefits:
- Protects object integrity
- Hides implementation 
- Allows internal changes without changing external code 


Different types of [[Exception]]

full property- get set alada vabe define kora

**Encapsulation is a mindset**

##### Auto-implement properties
for simpler data
90% implementation is simpler data 

###### Full
You declare the backing field explicitly to add custom logic such as validation, computed values, or change notifications.


## Data Validation and Computed Properties 

# Inheritance
Inheritance is a mechanism where a new class (derived) acquires properties and behavior of an existing class (base).

class er kichu behavior ache 
different jaygay same property, method gula dorkar
duplicate method na likhe, oi class gula base class ke inherit kore- parent class er shbkichu peye jacche 

- single inheritance: A -> B (only)
- multi level inh: A -> B -> C 
- hierarchical: A -> B and A -> C 

pros:
- logical hierarchy
- polymorphism
- code reuse

cons:
- tight coupling: real life software e ekdom bipode na porle inheritance use korina; instead use dependency injection 
  dependency injection loosely connect korar jnno onk proyojonio
- fragile base class problem: base class er requirement solidify hoy nai, ektu fragile ache- ripple effect create kore. 
- breaks incapsulation if not careful- careful na hole accessiblity break hoye jete pare 

