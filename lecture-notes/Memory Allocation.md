**Analogy:** Stack is like a stack of plates. Add/remove from the top automatically. Heap is like a big warehouse. You request space and a cleaner removes unused items later.

# Stack
fast, automatic memory
Data is removed automatically when the method ends (LIFO)
method calls

# Heap
Larger, slower memory. Stores objects that need to live longer.
managed manually 
reference type 

# Code
```cs
void Calculate()
{
int x = 10; // Stack
bool flag = true; // Stack
Person p = new Person(); // 'p' reference is on Stack
// Actual Person object is on Heap
}
// When Calculate() ends:
// x, flag, and reference 'p' are removed from Stack instantly
// The Person object on Heap stays until Garbage Collection
```

