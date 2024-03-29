namespace AreaCalculation
{
    public abstract class Shape
    {
        //private string _name;
        public double Square { get; protected set; }

        public Shape(/*string name*/)
        {
            //this._name = name;
        }

        protected abstract double GetArea();
    }
}