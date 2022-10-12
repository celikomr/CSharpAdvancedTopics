# Notes

## What is Interface?
An interface is a purely "abstract class" that can only include abstract methods and properties (without bodies). 
Interfaces help define a structure between your classes and objects. This indicates what sort of methods, properties, and events are exposed by an object.
Interfaces can contain instance methods, properties, events, indexers, or any combination of those four member types.

## How do we use it?
It is considered good practice to start with the letter "I" at the beginning of an interface, as it makes it easier for yourself and others to remember that it is an interface and not a class.
To access the interface methods, the interface must be "implemented" (kinda like inherited) by another class. To implement an interface, use the : symbol (just like with inheritance). 
The body of the interface method is provided by the implemented class. You do not have to use the override keyword when implementing an interface.
!! Interfaces can contain properties and methods, but not fields.

## Usefull Links
https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/interfaces