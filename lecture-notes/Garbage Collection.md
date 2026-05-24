C# uses **Automatic Memory Management**
The Garbage Collector (GC) cleans up **unused objects** from the **Heap**

GC runs automatically when memory is low or when the system is idle

**Benefits**
- Prevents memory leaks
- Prevents dangling pointers

**Object Lifetime**
- An object is "alive" as long as there is a reference to it
- When no variable points to an object, it becomes eligible for GC
- You can suggest GC to run, but you cannot force it