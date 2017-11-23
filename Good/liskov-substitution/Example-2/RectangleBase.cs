namespace liskov_substitution.Example_2
{
    public abstract class RectangleBase
    {
        protected double _height;
        protected double _width;

        public abstract void SetWidth(double width);

        public abstract void SetHeight(double height);

        public virtual double GetWidth()
        {
            return _width;
        }

        public virtual double GetHeight()
        {
            return _height;
        }
    }
}
