# Generics

## General Information Section

Generics in C# provide a powerful and flexible way to create reusable code that can work with different types while maintaining type safety. The concept of generics allows you to create classes, methods, and data structures that are not tied to a specific type at compile time. Instead, they can operate on any type specified by the caller during runtime.

The key feature of generics is type parameterization, which is achieved using angle brackets (<>) and a type parameter placeholder (often denoted as 'T'). This type parameter is replaced by an actual type when the generic code is used, allowing it to adapt to various data types seamlessly.

Here's a simple example of a generic method that returns the maximum of two elements:

```csharp
public T Max<T>(T a, T b) where T : IComparable<T>
{
    return a.CompareTo(b) >= 0 ? a : b;
}

```

In the above code, <T> indicates the type parameter, and the where T : IComparable<T> specifies a constraint that restricts T to types that implement the IComparable<T> interface.

## Useful Links

https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics

