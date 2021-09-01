using System;

namespace SimpleFactoryDesignPattern
{
    public class VehicleFactory
    {
        public Vehicle Create(EnumVehicleType type)
        {
            Vehicle vehicle;
            switch (type)
            {
                case EnumVehicleType.Car:
                    vehicle = new Car();
                    break;

                case EnumVehicleType.Motocicle:
                    vehicle = new Motocicle();
                    break;

                default:
                    throw new Exception("vehicle not valid");
            }

            return vehicle;
        }
    }
}