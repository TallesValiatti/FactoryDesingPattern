using System;

namespace FactoryMethodDesignPattern
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle();
    }

    public class CarFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Car();
        }
    }

    public class MotorcycleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Motorcycle();
        }
    }
}
