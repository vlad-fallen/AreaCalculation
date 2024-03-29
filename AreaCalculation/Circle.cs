using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("радиус имеет отрицательное значение");
            Radius = radius;
            Square = GetArea();
        }


        protected override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
