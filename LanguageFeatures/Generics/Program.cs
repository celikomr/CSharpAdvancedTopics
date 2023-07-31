using Generics;

// Covariance and Contravariance
// AnimalFactory<IAnimal> animalFactory = AnimalFactoryImpl.CreateDog;
// IAnimal animal = animalFactory();
// animal.MakeSound(); // Outputs: Woof!

// Generic Delegates and Events
// Button button = new Button();
// button.Clicked += GenericEventHandlerImp.Button_Clicked;
// button.OnClicked(); // Outputs: Button clicked!

// Generic Constraints with Enums
Logger<LogLevel> logger = new Logger<LogLevel>();
logger.Log(LogLevel.Warning, "This is a warning message.");
logger.Log(LogLevel.Error, "This is an error message.");