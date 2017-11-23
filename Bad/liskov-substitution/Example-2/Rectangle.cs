using System;

namespace liskov_substitution.Example_2
{
    public class Rectangle : RectangleBase
    {
        public override void SetHeight(double height)
        {
            _height = height;
        }

        public override void SetWidth(double width)
        {
            _width = width;
        }
    }
}
