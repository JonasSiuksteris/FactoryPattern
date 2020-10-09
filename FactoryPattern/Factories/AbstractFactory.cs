using FactoryPattern.Shapes;

namespace FactoryPattern.Factories
{
    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(string shapeType);
    }
}
