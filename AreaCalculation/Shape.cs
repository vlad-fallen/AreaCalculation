namespace AreaCalculation
{
    public abstract class Shape
    {
        private string _name;

        public Shape(string name)
        {
            this._name = name;
        }

        public abstract double GetArea();
    }
}