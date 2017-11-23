using System;

namespace liskov_substitution.Example_1
{
    public class ShapeProcesser
    {
        public void DrawShape(Shape s)
        {
            if (s is Square)
                DrawSquare((Square)s);
            else if (s is Circle)
                DrawCircle((Circle)s);
        }

        private void DrawSquare(Square s)
        {
            Console.WriteLine("Draw square");
        }

        private void DrawCircle(Circle s)
        {
            Console.WriteLine("Draw circle");
        }
    }
}
