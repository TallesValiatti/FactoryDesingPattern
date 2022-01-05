using System;

namespace AbstractFactoryDesignPattern
{
    public interface IMotorcycle : IVehicle
    { 
    }

    public class ModernMotorcycle : IMotorcycle
    {
        public void DoSomeWork()
        {
            Console.WriteLine("Modern motocicle is doing some work");
        }
    }

    public class VintageMotorcycle : IMotorcycle
    {
        public void DoSomeWork()
        {
            Console.WriteLine("Vintage motocicle is doing some work");
        }
    }
}
