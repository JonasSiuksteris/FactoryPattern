using System;

namespace FactoryPattern.Shapes
{
    public class RoundedSquare : IShape
    {
        public void Draw()
        {
            Console.WriteLine("A pretty rounded square");
        }
    }
}
