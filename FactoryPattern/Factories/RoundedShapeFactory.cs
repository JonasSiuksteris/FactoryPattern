using FactoryPattern.Shapes;

namespace FactoryPattern.Factories
{
    public class RoundedShapeFactory : AbstractFactory
    {
        public override IShape GetShape(string shapeType)
        {
            return shapeType switch
            {
                "rectangle" => (IShape) new RoundedRectangle(),
                "square" => new RoundedSquare(),
                _ => null
            };
        }
    }
}
