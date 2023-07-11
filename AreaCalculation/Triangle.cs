using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    public class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public double A { get { return a; } set { a = value > 0 ? value : -value; } }
        public double B { get { return b; } set { b = value > 0 ? value : -value; } }
        public double C { get { return c; } set { c = value > 0 ? value : -value; } }

        public Triangle(double a, double b, double c) : base("Triangle")
        {
            A = a; B = b; C = c;

            if (!checkTriangle(A, B, C))
            {
                Console.WriteLine("It is not a triangle - created default!");
                throw new ArgumentOutOfRangeException("Not a triangle");
            }
        }

        private bool checkTriangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            
            return false;
        }

        public override double GetArea()
        {
            double area = 0;

            double p = (A + B + C) / 2;
            
            area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return area;
        }

        public bool CheckRightTriangle()
        {
            List<double> sides = new List<double>() { A, B, C };

            double longSide = sides.Max();

            sides.Remove(longSide);

            if (Math.Pow(longSide, 2) == (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)))
                return true;

            return false;
        }
    }
}
