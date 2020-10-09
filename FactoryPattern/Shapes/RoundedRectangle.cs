using System;

namespace FactoryPattern.Shapes
{
    public class RoundedRectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("A pretty rounded rectangle");
        }
    }
}
