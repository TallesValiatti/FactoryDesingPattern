using System;

namespace AbstractFactoryDesignPattern
{
    public interface IMotocicle : IVehicle
    { 
    }

    public class ModernMotocicle : IMotocicle
    {
        public void DoSomeWork()
        {
            Console.WriteLine("Modern motocicle is doing some work");
        }
    }

    public class VintageMotocicle : IMotocicle
    {
        public void DoSomeWork()
        {
            Console.WriteLine("Vintage motocicle is doing some work");
        }
    }
}
