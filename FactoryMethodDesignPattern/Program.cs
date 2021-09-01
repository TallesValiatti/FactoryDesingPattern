using System;

namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeBusinessLogicOne();
            SomeBusinessLogicTwo();
        }

        private static void SomeBusinessLogicOne()
        {
            // Some business logic
            
            IVehicleFactory vehicleFactory = new CarFactory();
            IVehicle vehicle = vehicleFactory.CreateVehicle();
            vehicle.DoSomeWork();

            // More business logic
        }

        private static void SomeBusinessLogicTwo()
        {
            // Some business logic

            IVehicleFactory vehicleFactory = new MotocicleFactory();
            IVehicle vehicle = vehicleFactory.CreateVehicle();
            vehicle.DoSomeWork();

            // More business logic
        }
    }
}
