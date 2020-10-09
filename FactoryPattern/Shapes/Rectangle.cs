using System;

namespace FactoryPattern.Shapes
{
    public class Rectangle: IShape
    {
        public void Draw()
        {
            Console.WriteLine("A pretty rectangle");
        }
    }
}
