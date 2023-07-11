using Xunit;
using AreaCalculation;
using System;

namespace AreaCalculationTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestWrongParameters()
        {
            double a = 1;
            double b = 2;
            double c = 3;

            try
            {
                new Triangle(a, b, c);
                Assert.Fail("Exception not thrown");
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        [Fact]
        public void TestRightTriangle()
        {
            double a = 3;
            double b = 4;
            double c = 5;

            Triangle triangle = new Triangle(a, b, c);

            bool result = triangle.CheckRightTriangle();

            Assert.True(result);
        }
    }
}