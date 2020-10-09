using FactoryPattern.Factories;

namespace FactoryPattern
{
    internal class Program
    {
        private static void Main()
        {
            var shapeFactory = FactoryProducer.GetFactory(false);

            var shape1 = shapeFactory.GetShape(ShapesEnum.Rectangle);

            shape1.Draw();

            var shape2 = shapeFactory.GetShape(ShapesEnum.Square);

            shape2.Draw();

            shapeFactory = FactoryProducer.GetFactory(true);

            var shape3 = shapeFactory.GetShape(ShapesEnum.Rectangle);

            shape3.Draw();

            var shape4 = shapeFactory.GetShape(ShapesEnum.Square);

            shape4.Draw();
        }
    }
}
