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

    public class MotocicleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Motocicle();
        }
    }
}
