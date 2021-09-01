using System;

namespace AbstractFactoryDesignPattern
{
    public interface ICar : IVehicle
    { 
    }

    public class ModernCar : ICar
    {
        public void DoSomeWork()
        {
            Console.WriteLine("Modern car is doing some work");
        }
    }

    public class VintageCar : ICar
    {
        public void DoSomeWork()
        {
            Console.WriteLine("Vintage car is doing some work");
        }
    }
}
