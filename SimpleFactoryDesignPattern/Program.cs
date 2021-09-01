namespace SimpleFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeBusinessLogic(EnumVehicleType.Motocicle);

            SomeBusinessLogic(EnumVehicleType.Car);
        }

        static void SomeBusinessLogic(EnumVehicleType type)
        {
            // Some business logic

            var vehicleFactory = new VehicleFactory();
            var vehicle = vehicleFactory.Create(type);
            vehicle.DoSomeWork();

            // More business logic
        }
    }
}