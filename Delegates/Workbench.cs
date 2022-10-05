namespace Delegates
{
    // Declaring Delegate(s)
    public delegate int CalculaterDelegate(int x);
    public delegate bool FilterDelegate(Person p);

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach (Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }

            Console.Write("\n\n");
        }

        // ********* Fiters *********
        public static bool IsChild(Person p)
        {
            return p.Age < 18;
        }

        public static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        public static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
    }

    public class Calculater
    {
        static int value = 0;

        public static int Addition(int x)
        {
            value += x;
            return value;
        }

        public static int Subtraction(int x)
        {
            value -= x;
            return value;
        }

        public static int Multiplication(int x)
        {
            value *= x;
            return value;
        }

        public static int Division(int x)
        {
            value /= x;
            return value;
        }

        public static int GetValue()
        {
            return value;
        }

        public static double SumNumber1(int number1, float number2, double number3)
        {
            return number1 + number2 + number3;
        }

        public static void SumNumber2(int number1, float number2, double number3)
        {
            Console.WriteLine(number1 + number2 + number3);
        }

        public static bool CheckTheLength(string name)
        {
            if (name.Length < 10)
                return true;
            return false;
        }
    }
}