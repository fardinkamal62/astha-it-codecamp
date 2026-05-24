---
tags: Notes
date: 2026-05-06T21:00:00
---
**Topic:** C# Syntax, Fundamentals & Memory Management

## What is C\#
C# is a modern Object Oriented Programming language by Microsoft
MS created C# to be comparable with Java

C# runs on .net runtime
And SDK(software development kit) is used to develop C# program

We need the full development kit to develop, build and run ASP.net

Latest version of .net is 11 preview

### Used in 
Games, web, cloud, mobile etc. 


## Basic Program Structure 
To create a new project, run this in the terminal:
```bash
dotnet new console
```
it will create a new project `console` with boilerplate code in the current directory.
#### Different types of project
With C#, we can create different types of project such as console based, web or mobile.
Console apps are basically CLI tools


`class.csproj` contains project configuration

To build & run a program:
```bash
dotnet run
```


## [[Types]]

Method: pascal case | e.g.: FirstName
Variable: camel case | e.g.: firstName


### Type conversion
#### implicit conversion
small type → large type
kono data loss hocchena

```cs
int num = 10;
double bigNum = num
```

#### Explicit conversion
Manual, requires care (large type → small type)
error dekhabe because data loss:
```cs
double price = 12.9;
int x = price;
```

#### cast:
```cs 
double price = 12.9;
int x = (int)price;
```


# Procedural vs OOP
**Analogy:**
	Procedural is like a recipe list (step 1, step 2, step 3), OOP is like a kitchen with tools (Oven, Mixer, Fridge) that have their own functions.
## Procedural
Code runs from top to bottom
good for small script 
hard to maintain as code grows
vairable and functions only 

## OOP
Code is organized into objects
Objects combine data and behaviors
	data: fields 
	behavior: methods

Field: `public int number;`
Property: `public int number { get; set;}`

# [[Access Modifiers]]
> **Best Practice**: Make fields private, expose them via public properties or methods.

**Fields vs Property**
	kono ekta variable er getter setter na thakle field, thakle property
	Field is a variable, that no one can access
	using Property we can make it available for others to access/modify

# [[Memory Allocation]]
C# is a garbage collected language 

# Constructor
A constructor is a special method that runs when an object is created
It has the same name as the class and no return type

## Types of constructors
- Default: No parameters. Sets default values.
- Parameterized: Accepts arguments to initialize fields.
- Copy: Creates a new object from an existing object.

### Code
```cs
class Car
{
	public string Brand;
	public int Year;
	// Default Constructor
	public Car()
	{
		Brand = "Unknown";
		Year = 0;
	}
	// Parameterized Constructor
	public Car(string brand, int year)
	{
		Brand = brand;
		Year = year;
	}
}
Car c1 = new Car(); // Uses default
Car c2 = new Car("Toyota", 2023); // Uses parameterized
```

**Copy example**
```cs
class Employee
{
	public string Name;
	public int ID;
	
	public Employee(string name, int id)
	{
		Name = name;
		ID = id;
	}
	// Copy Constructor
	public Employee(Employee other)
	{
		Name = other.Name;
		ID = other.ID;
	}
}
Employee e1 = new Employee("Ali", 101);
Employee e2 = new Employee(e1); // Copy of e1
```

# [[Garbage Collection]]
