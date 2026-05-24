Value types and reference types are the two main categories of C# types

tl;dr
Assigning a value type = creates a copy
Assigning a reference type = creates a shared reference
# Value type
Also known as: _simple types_
Value types store the **actual data** directly and are allocated on the **stack**

Value types:
- int
- float
- bool
- char
- struct 

A value type can be one of the following kinds:

- A [structure type](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct), which encapsulates data and related functionality.
- An [enumeration type](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum), which is defined by a set of named constants and represents a choice or a combination of choices.
- A [union declaration](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/union), which defines a closed set of case types that a value can represent.

# Reference type
Reference types store a **reference to the data's memory location** and are allocated on the **heap**

Reference types:
- dynamic
- object 
- string 
- array

Use the following keywords to declare reference types:
- class
- interface
- delegate
- record

# Code Example
```cs
// Value Type
int a = 10;
int b = a; // b gets a COPY of 10
b = 20;
Console.WriteLine(a); // Output: 10 (unchanged)
// Reference Type
int[] arr1 = { 1, 2, 3 };
int[] arr2 = arr1; // arr2 points to SAME data
arr2[0] = 99;
Console.WriteLine(arr1[0]); // Output: 99 (changed!)
```
