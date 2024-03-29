using Xunit;
using AreaCalculation;
using System;

namespace AreaCalculationTest
{
    public class UnitTest1
    {
        [Fact]
        public void CircleNegativeParameterTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-10));
        }

        [Fact]
        public void CircleZeroParameterTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
        }

        [Fact]
        public void TriangleNegativeParameterTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-10, 10, 10));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(10, -10, 10));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(10, 10, -10));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-10, -10, -10));
        }

        [Fact]
        public void TriangleZeroParameterTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 10, 10));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(10, 0, 10));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(10, 10, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, 0));
        }

        [Fact]
        public void CircleSquareCalculationTest()
        {
            var circle = new Circle(10);

            var square = circle.Square;

            Assert.Equal(314.15926535897933, square);
        }

        [Fact]
        public void TriangleSquareCalculationTest()
        {
            var tringle = new Triangle(3, 4, 5);

            var square = tringle.Square;

            Assert.Equal(6, square);
        }

        [Fact]
        public void RightTriangleTest()
        {
            var rightTriangle = new Triangle(3, 4, 5);
            var triangle = new Triangle(1, 1, 1);
            
            var isRightTriangle = rightTriangle.IsRightTriangle;
            var notRightTriangle = triangle.IsRightTriangle;

            Assert.True(isRightTriangle);
            Assert.False(notRightTriangle);
        }

        [Fact]
        public void SideTriangleTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 1, 3));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 3, 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(3, 1, 1));
        }
    }
}