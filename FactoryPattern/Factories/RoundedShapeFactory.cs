using FactoryPattern.Shapes;

namespace FactoryPattern.Factories
{
    public class RoundedShapeFactory : AbstractFactory
    {
        public override IShape GetShape(ShapesEnum shapeType)
        {
            return shapeType switch
            {
                ShapesEnum.Rectangle => (IShape) new RoundedRectangle(),
                ShapesEnum.Square => new RoundedSquare(),
                _ => null
            };
        }
    }
}
