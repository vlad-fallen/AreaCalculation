namespace AreaCalculation
{
    public abstract class Shape
    {
        public double Square { get; protected set; }

        public Shape()
        {
        }

        protected abstract double GetArea();
    }
}