namespace Delegates;

class Program
{
    // Anonymous Methods
    delegate void GreetingDelegate(string message);

    // Closure and Captured Variables
    delegate void CounterDelegate();


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
    }
}
