using FactoryPattern.Shapes;

namespace FactoryPattern.Factories
{
    public class ShapeFactory : AbstractFactory
    {
        public override IShape GetShape(ShapesEnum shapeType)
        {
            return shapeType switch
            {
                ShapesEnum.Rectangle => new Rectangle(),
                ShapesEnum.Square => new Square(),
                _ => null
            };
        }
    }
}
