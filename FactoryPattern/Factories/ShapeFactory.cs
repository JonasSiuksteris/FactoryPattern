using FactoryPattern.Shapes;

namespace FactoryPattern.Factories
{
    public class ShapeFactory : AbstractFactory
    {
        public override IShape GetShape(string shapeType)
        {
            return shapeType switch
            {
                "rectangle" => (IShape) new Rectangle(),
                "square" => new Square(),
                _ => null
            };
        }
    }
}
