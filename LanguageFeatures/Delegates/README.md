# Notes


## What is delegate ?
A delegate is a type that represents references to methods with a particular parameter list and return type. When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type. You can invoke (or call) the method through the delegate instance.

## Why and when to use delegate(s) ?
I believe that a lot of people can answer the "what is a delegate?" question in interviews but are not able to explain when to use it. No worries! Let me tell you a few important points about delegates.

- These are used to represent or refer to one or more functions.
- These can only be used to define call-back methods.
- In order to consume a delegate, we need to create an object to delegate.

- Event handlers (for GUI and more)
- Starting threads
- Callbacks (e.g. for async APIs)
- LINQ and similar (List.Find etc)
- Anywhere else where I want to effectively apply "template" code with some specialized logic inside (where the delegate provides the specialization)

## Types of delegate(s)

- Single Delegates
- Multi Delegates
- Generic Delegates
	- Func Delegate
	- Action Delegate
	- Predicate Delegate

## Encyclopedia Of Terms

## Useful Links