using System;

namespace liskov_substitution
{
    class Program
    {
        static void Main(string[] args)
        {
            var process = new Example_1.ShapeProcesser();

            var circle = new Example_1.Circle();
            var square = new Example_1.Square();

            process.DrawShape(circle);
            process.DrawShape(square);

            var rectangle = new Example_2.Rectangle();
            Area(rectangle);

            var anotherSquare = new Example_2.Square();
            Area(anotherSquare);

            Console.ReadKey();
        }

        private static void Area(Example_2.RectangleBase rectangle)
        {
            rectangle.SetHeight(4);
            rectangle.SetWidth(5);

            Console.WriteLine("Is the shape area 20? {0}", rectangle.GetHeight() * rectangle.GetWidth() == 20);
        }
    }
}
