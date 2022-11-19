using System;
using Xunit;

namespace DiagramAnalysisTest
{
    public class UnitTest1
    {
        
        [Fact]
        public void TestWithRectangle()
        {
            var sut = new Rectangle
            {
                Height = 3,
                Width = 7
            };
            Assert.Equal(21, sut.Area);
        }

        [Fact]
        public void TestWithSquare()
        {
            var sut = new Square
            {
                Height = 3,
                Width = 7
            };
            Assert.Equal(49, sut.Area); 
        }

        [Fact]
        public void TestWithCircle()
        {
            const decimal radius  = 3;
            const decimal expectedResult = radius * radius * (decimal)Math.PI;

            var sut = new Circle()
            {
                Radius = radius
            };
            Assert.Equal(expectedResult, sut.Area); 
        }

        [Fact]
        public void TestAggregate()
        {

            var circle = new Circle { Radius = 3 };
            var rectangle = new Rectangle { Height = 3, Width = 7 };
            var square = new Square { Height = 3, Width = 3};

            var expectedResult = circle.Area + rectangle.Area + square.Area;

            Assert.Equal(expectedResult, AreaAggregator.SumArea( circle, rectangle, square ));

        }
    }
}
