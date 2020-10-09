using System;

namespace FactoryPattern.Shapes
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("A pretty square");
        }
    }
}
