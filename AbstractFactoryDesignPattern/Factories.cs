namespace AbstractFactoryDesignPattern
{
    public interface IFactory
    {
        ICar CreateCar();
        IMotocicle CreateMotocicle();
    }

    public class VintageFactory : IFactory
    {
        public ICar CreateCar()
        {
            return new VintageCar();
        }

        public IMotocicle CreateMotocicle()
        {
            return new VintageMotocicle();
        }
    }

    public class ModernFactory : IFactory
    {
        public ICar CreateCar()
        {
            return new ModernCar();
        }

        public IMotocicle CreateMotocicle()
        {
            return new ModernMotocicle();
        }
    }
}
