namespace Interfaces
{
    public interface IVehicle
    {
        void ShowModel();
    }

    class Car : IVehicle
    {
        public string Model { get; set; }

        Car(string model)
        {
            Model = model;
        }

        public void ShowModel()
        {
            Console.WriteLine("Cars Model is: " +  Model);
        }
    }

    class Bus : IVehicle
    {
        public string Model { get; set; }

        Bus()
        {
            Model = "BMC";
        }

        public void ShowModel()
        {
            Console.WriteLine("Busses Model is: "  + Model);
        }
    }
}
