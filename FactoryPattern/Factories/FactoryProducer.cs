namespace FactoryPattern.Factories
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(bool rounded)
        {
            if (rounded)
                return new RoundedShapeFactory();
            return new ShapeFactory();
        }
    }
}
