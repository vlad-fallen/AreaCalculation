using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    public class Triangle : Shape
    {
        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }

        public bool IsRightTriangle { get; private set; }

        public Triangle(double a, double b, double c) 
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("сторона треугольника имеет отрицательное значение или равно нулю");

            FirstSide = a; SecondSide = b; ThirdSide = c;

            if (!checkTriangle(FirstSide, SecondSide, ThirdSide))
                throw new ArgumentOutOfRangeException("Not a triangle");

            Square = GetArea();
            IsRightTriangle = CheckRightTriangle();
        }

        private bool checkTriangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            
            return false;
        }

        protected override double GetArea()
        {
            double p = (FirstSide + SecondSide + ThirdSide) / 2;
            
            return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
        }

        protected bool CheckRightTriangle()
        {
            var a = FirstSide;
            var b = SecondSide;
            var c = ThirdSide;

            if (a * a == (b * b + c * c))
                return true;
            else if (b * b == (c * c + a * a))
                return true;
            else if (c * c == (a * a + b * b))
                return true;

            return false;
        }
    }
}
