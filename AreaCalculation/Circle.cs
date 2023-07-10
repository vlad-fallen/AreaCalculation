using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    public class Circle : Shape
    {
        private double _radius;

        public double Radius { 
            get { return _radius; } 
            set { _radius = value > 0 ? value : -value; } 
        }

        public Circle(double radius) : base("Circle")
        {
            this.Radius = radius;
        }

        public override double GetArea()
        {
            double area = 0;

            area = Math.PI * Radius * Radius;

            return area;
        }
    }
}
