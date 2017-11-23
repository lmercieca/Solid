using System;

namespace liskov_substitution.Example_2
{
    public class Square : RectangleBase
    {
        public override void SetHeight(double height)
        {
            _height = height;
            _width = height;
        }

        public override void SetWidth(double width)
        {
            _height = width;
            _width = width;
        }
    }
}
