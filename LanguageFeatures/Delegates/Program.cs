namespace Delegates;

class Program
{
    // Anonymous Methods
    delegate void GreetingDelegate(string message);

    // Closure and Captured Variables
    delegate void CounterDelegate();

    // Custom Delegate Types
    delegate void CalculationDelegate(int a, int b);

    static void Main(string[] args)
    {
        #region Anonymous Methods
        GreetingDelegate greet = delegate (string msg)
        {
            Console.WriteLine("Hello, " + msg);
        };

        greet("John");
        #endregion

        #region Closure and Captured Variables
        int count = 0;
        CounterDelegate counter = () =>
        {
            count++;
            Console.WriteLine("Count: " + count);
        };

        counter();
        counter();
        #endregion

        #region Built-in Delegate Types
        Predicate<int> isEven = num => num % 2 == 0;
        Console.WriteLine(isEven(4)); // True

        int[] numbers = { 1, 2, 3, 4, 5 };
        var evenNumbers = Array.FindAll(numbers, isEven);
        Console.WriteLine(string.Join(", ", evenNumbers)); // 2, 4
        #endregion

        #region Custom Delegate Types
        CalculationDelegate add = (x, y) => Console.WriteLine("Sum: " + (x + y));
        CalculationDelegate subtract = (x, y) => Console.WriteLine("Difference: " + (x - y));

        add(10, 5);
        subtract(20, 7);
        #endregion

        #region Events with Delegates
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();

        publisher.EventOccurred += subscriber.HandleEvent;
        publisher.DoSomething();
        #endregion
    }
}

#region Events with Delegates
class Publisher
{
    public delegate void EventHandler(string message);
    public event EventHandler EventOccurred;

    public void DoSomething()
    {
        Console.WriteLine("Something happened.");
        EventOccurred?.Invoke("Event occurred!");
    }
}

class Subscriber
{
    public void HandleEvent(string message)
    {
        Console.WriteLine("Subscriber received: " + message);
    }
}
#endregion
