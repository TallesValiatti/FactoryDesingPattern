using System;

namespace FactoryMethodDesignPattern
{
    public interface IVehicle
    {
        void DoSomeWork();
    }

    public class Car : IVehicle
    {
        public void DoSomeWork()
        {
            Console.WriteLine("Car is doing some work");
        }
    }

    public class Motorcycle : IVehicle
    {
        public void DoSomeWork()
        {
            Console.WriteLine("Motorcycle is doing some work");
        }
    }
}
