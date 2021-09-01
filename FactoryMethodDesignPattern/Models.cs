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

    public class Motocicle : IVehicle
    {
        public void DoSomeWork()
        {
            Console.WriteLine("Motocicle is doing some work");
        }
    }
}
