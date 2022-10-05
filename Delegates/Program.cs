using Delegates;

// Instantiating Delegate(s)
CalculaterDelegate calculater1 = Calculater.Addition;
CalculaterDelegate calculater2 = Calculater.Subtraction;
CalculaterDelegate calculater3 = Calculater.Multiplication;
CalculaterDelegate calculater4 = Calculater.Division;

// Calling method(s) using delegate(s)
calculater1(20);
Console.WriteLine($"After calculater1 delegate, value is: {Calculater.GetValue()}");

calculater2(3);
Console.WriteLine($"After calculater2 delegate, value is: {Calculater.GetValue()}");

calculater3(5);
Console.WriteLine($"After calculater3 delegate, value is: {Calculater.GetValue()}");

calculater4(5);
Console.WriteLine($"After calculater4 delegate, value is: {Calculater.GetValue()}");


// Generic Type Delegate(s)
// Func Delegate
Func<int, float, double, double> func = Calculater.SumNumber1;
double output = func(10, 12.15f, 45.78);
Console.WriteLine(output);

// Action Delegate
Action<int, float, double> action = Calculater.SumNumber2;
action(20, 22.35f, 11.33);

// Predicate Delegate
Predicate<string> predicate = Calculater.CheckTheLength;
bool b = predicate("Hello world");
Console.WriteLine(b);


// Sample
// Create 4 Person objects
Person p1 = new () { Name = "John", Age = 41 };
Person p2 = new () { Name = "Jane", Age = 69 };
Person p3 = new () { Name = "Jake", Age = 12 };
Person p4 = new () { Name = "Jessie", Age = 25 };

// Create a list of Person objects and fill it
List<Person> people = new () { p1, p2, p3, p4 };

// Invoke DisplayPeople using appropriate delegate
Person.DisplayPeople("Children:", people, Person.IsChild);
Person.DisplayPeople("Adults:", people, Person.IsAdult);
Person.DisplayPeople("Seniors:", people, Person.IsSenior);

Console.Read();
