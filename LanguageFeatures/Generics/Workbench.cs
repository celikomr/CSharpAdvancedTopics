namespace Generics;


#region Multiple Type Parameters
public class Pair<T, U>
{
    public Pair(T first, U second)
    {
        First = first;
        Second = second;
    }

    public T First { get; set; }
    public U Second { get; set; }
}

// The example above defines the generic class Pair for two different types.
// The Pair class can be used to store two different types of values and return their first and second elements.
#endregion

#region Covariance and Contravariance
public interface IAnimal
{
    void MakeSound();
}

public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

public delegate TAnimal AnimalFactory<out TAnimal>();

public class AnimalFactoryImpl
{
    public static Dog CreateDog()
    {
        return new Dog();
    }
}
#endregion

#region Generic Delegates and Events
public delegate void GenericEventHandler<TEventArgs>(object sender, TEventArgs e);

public class Button
{
    public event GenericEventHandler<EventArgs> Clicked;

    public void OnClicked()
    {
        Clicked?.Invoke(this, EventArgs.Empty);
    }
}

public class GenericEventHandlerImp
{
    public static void Button_Clicked(object sender, EventArgs e)
    {
        Console.WriteLine("Button clicked!");
    }
}

// The example above demonstrates using a generic delegate, GenericEventHandler<TEventArgs>, and creating an event using this delegate.
// The Button class defines the generic event Clicked and the OnClicked method is used to trigger this event.
#endregion

#region Recursive Generics
public class TreeNode<T>
{
    public T Value { get; set; }
    public List<TreeNode<T>> Children { get; set; }

    public TreeNode(T value)
    {
        Value = value;
        Children = new List<TreeNode<T>>();
    }
}

// The above example defines the recursive generic class TreeNode<T> to create a tree structure.
// Each node is represented by a Value of a certain type, and its Children properties are kept in a List<TreeNode<T>> type that represents child nodes.
#endregion

#region Generic Constraints with Enums
public enum LogLevel
{
    Info,
    Warning,
    Error
}

public class Logger<TLogLevel> where TLogLevel : Enum
{
    public void Log(TLogLevel logLevel, string message)
    {
        Console.WriteLine($"[{logLevel}] {message}");
    }
}

// The above example performs logging using the generic class Logger<TLogLevel>.
// The TLogLevel type must be Enum so that restrictions are placed on only a specific enum type and valid log levels are limited to only a specific Enum type.
#endregion
