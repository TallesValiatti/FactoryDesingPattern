namespace AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeBusinessLogicOne();
            SomeBusinessLogicTwo();
        }

        private static void SomeBusinessLogicOne()
        {
            // Some business logic

            IFactory factory = new ModernFactory();
            ICar car = factory.CreateCar();
            IMotocicle motocicle = factory.CreateMotocicle();

            car.DoSomeWork();
            motocicle.DoSomeWork();

            // More business logic
        }

        private static void SomeBusinessLogicTwo()
        {
            // Some business logic

            IFactory factory = new VintageFactory();
            ICar car = factory.CreateCar();
            IMotocicle motocicle = factory.CreateMotocicle();

            car.DoSomeWork();
            motocicle.DoSomeWork();

            // More business logic
        }
    }
}
