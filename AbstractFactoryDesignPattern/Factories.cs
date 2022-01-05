namespace AbstractFactoryDesignPattern
{
    public interface IFactory
    {
        ICar CreateCar();
        IMotorcycle CreateMotorcycle();
    }

    public class VintageFactory : IFactory
    {
        public ICar CreateCar()
        {
            return new VintageCar();
        }

        public IMotorcycle CreateMotorcycle()
        {
            return new VintageMotorcycle();
        }
    }

    public class ModernFactory : IFactory
    {
        public ICar CreateCar()
        {
            return new ModernCar();
        }

        public IMotorcycle CreateMotorcycle()
        {
            return new ModernMotorcycle();
        }
    }
}
