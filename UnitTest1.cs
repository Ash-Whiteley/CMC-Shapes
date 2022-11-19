using System;
using System.Threading.Tasks;
using ShapesTest.Shapes.Helpers;
using Xunit;

namespace ShapesTest
{
    public class ShapeTests
    {
        [Fact]
        public void TestWithRectangle() => this.Rectangle(99.4M, 33.2M);

        [Fact]
        public void TestWithRectangle2() => this.Rectangle(35.4M, 152.9M);

        [Fact]
        public void TestWithRectangle3() => this.Rectangle(2.5M, 10.1M);

        [Fact]
        public void TestWithRectangleHeightNegative()
        {
            try
            {
                this.Rectangle(-2.5M, 10.1M);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.True(true);
                return;
            }

            Assert.True(false);
        }

        [Fact]
        public void TestWithRectangleWidthNegative()
        {
            try
            {
                this.Rectangle(2.5M, -10.1M);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.True(true);
                return;
            }

            Assert.True(false);
        }

        [Fact]
        public void TestWithSquare() => this.Square(2.5M);

        [Fact]
        public void TestWithSquare2() => this.Square(192.5M);

        [Fact]
        public void TestWithSquare3() => this.Square(33.33M);

        [Fact]
        public void TestWithSquareNegative()
        {
            try
            {
                this.Square(-33.33M);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.True(true);
                return;
            }

            Assert.True(false);
        }

        [Fact]
        public void TestWithCircle() => this.Circle(92.2M);

        [Fact]
        public void TestWithCircle2() => this.Circle(432.14M);

        [Fact]
        public void TestWithCircle3() => this.Circle(15.2M);

        [Fact]
        public void TestWithCircleNegative()
        {
            try
            {
                this.Circle(-15.2M);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.True(true);
                return;
            }

            Assert.True(false);
        }

        [Fact]
        public void TestAggregate() => this.Aggregate(15.0M, 19.2M, 54.9M, 15.35M);

        [Fact]
        private void TestNullAggregateObject()
        {
            const decimal circleRadius = 54.25M;
            const decimal squareLength = 5.35M;

            var circle = Factories.ShapeFactory.CreateCircle(radius: circleRadius);
            var square = Factories.ShapeFactory.CreateSquare(length: squareLength);

            var expectedResult = circle.Area + square.Area;

            Assert.Equal(expectedResult, AreaAggregator.SumArea(circle, null, square));
        }

        [Fact]
        private void TestNullAggregateObject2()
        {
            var expectedResult = 0M;

            Assert.Equal(expectedResult, AreaAggregator.SumArea(null, null));
        }

        [Fact]
        private async void TestDefaultAreaDisplay()
        {
            const decimal circleRadius = 33.25M;
            const decimal squareLength = 19.35M;
            const decimal rectangleHeight = 921.41M;
            const decimal rectangleWidth = 1.25M;

            var expectedCircleResult = CalculateCircleArea(circleRadius);
            var expectedSquareResult = CalculateQuadrilateralArea(squareLength, squareLength);
            var expectedRectangleResult = CalculateQuadrilateralArea(rectangleHeight, rectangleWidth);

            var circle = Factories.ShapeFactory.CreateCircle(radius: circleRadius);
            var square = Factories.ShapeFactory.CreateSquare(length: squareLength);
            var rectangle = Factories.ShapeFactory.CreateRectangle(height: rectangleHeight, width: rectangleWidth);

            var areaDisplay = Factories.DisplayFactory.CreateAreaDisplay();

            await areaDisplay.DisplayAsync(circle, square, rectangle);

            Assert.Equal(expectedCircleResult, circle.Area);
            Assert.Equal(expectedSquareResult, square.Area);
            Assert.Equal(expectedRectangleResult, rectangle.Area);
        }

        [Fact]
        private async void TestPrinterAreaDisplay()
        {
            const decimal circleRadius = 93.25M;
            const decimal squareLength = 142.35M;
            const decimal rectangleHeight = 542.42M;
            const decimal rectangleWidth = 32.25M;

            var expectedCircleResult = CalculateCircleArea(circleRadius);
            var expectedSquareResult = CalculateQuadrilateralArea(squareLength, squareLength);
            var expectedRectangleResult = CalculateQuadrilateralArea(rectangleHeight, rectangleWidth);

            var circle = Factories.ShapeFactory.CreateCircle(radius: circleRadius);
            var square = Factories.ShapeFactory.CreateSquare(length: squareLength);
            var rectangle = Factories.ShapeFactory.CreateRectangle(height: rectangleHeight, width: rectangleWidth);

            var areaDisplay = Factories.DisplayFactory.CreateAreaDisplay(Factories.WriterFactory.CreatePrinter());

            await areaDisplay.DisplayAsync(circle, square, rectangle);

            Assert.Equal(expectedCircleResult, circle.Area);
            Assert.Equal(expectedSquareResult, square.Area);
            Assert.Equal(expectedRectangleResult, rectangle.Area);
        }

        [Fact]
        public async void TestLoggableAreaDisplay() => await this.AreaDisplayLoggable(22.5M, 13.24M, 15.33M, 11.25M);

        [Fact]
        public async void TestLoggableAreaDisplay2() => await this.AreaDisplayLoggable(18.5M, 114.24M, 64.33M, 34.25M);

        [Fact]
        public async void TestLoggableAreaDisplay3() => await this.AreaDisplayLoggable(192.523M, 79.12M, 62.11M, 43.44M);

        private void Rectangle(decimal rectangleHeight, decimal rectangleWidth)
        {
            var expectedRectangleResult = CalculateQuadrilateralArea(rectangleHeight, rectangleWidth);

            var rectangle = Factories.ShapeFactory.CreateRectangle(height: rectangleHeight, width: rectangleWidth);

            Assert.Equal(expectedRectangleResult, rectangle.Area);
        }

        private void Square(decimal squareLength)
        {
            var expectedSquareResult = CalculateQuadrilateralArea(squareLength, squareLength);

            var square = Factories.ShapeFactory.CreateSquare(squareLength);

            Assert.Equal(expectedSquareResult, square.Area);
        }

        private void Circle(decimal circleRadius)
        {
            var expectedCircleResult = CalculateCircleArea(circleRadius);

            var circle = Factories.ShapeFactory.CreateCircle(radius: circleRadius);

            Assert.Equal(expectedCircleResult, circle.Area);
        }

        private void Aggregate(decimal circleRadius, decimal squareLength, decimal rectangleHeight, decimal rectangleWidth)
        {
            var circle = Factories.ShapeFactory.CreateCircle(radius: circleRadius);
            var rectangle = Factories.ShapeFactory.CreateRectangle(height: rectangleHeight, width: rectangleWidth);
            var square = Factories.ShapeFactory.CreateSquare(length: squareLength);

            var expectedResult = circle.Area + rectangle.Area + square.Area;

            Assert.Equal(expectedResult, AreaAggregator.SumArea(circle, rectangle, square));
        }

        private async ValueTask AreaDisplayLoggable(decimal circleRadius, decimal squareLength, decimal rectangleHeight, decimal rectangleWidth)
        {
            var expectedCircleResult = CalculateCircleArea(circleRadius).ToString();
            var expectedSquareResult = CalculateQuadrilateralArea(squareLength, squareLength).ToString();
            var expectedRectangleResult = CalculateQuadrilateralArea(rectangleHeight, rectangleWidth).ToString();

            var circle = Factories.ShapeFactory.CreateCircle(radius: circleRadius);
            var square = Factories.ShapeFactory.CreateSquare(length: squareLength);
            var rectangle = Factories.ShapeFactory.CreateRectangle(height: rectangleHeight, width: rectangleWidth);

            var areaDisplay = Factories.DisplayFactory.CreateAreaDisplay(Factories.WriterFactory.CreateLoggablePrinter());

            await areaDisplay.DisplayAsync(circle, square, rectangle);

            var writerLogs = ((Interfaces.ILoggableWriter)areaDisplay.Writer).Logs;

            Assert.Equal(expectedCircleResult, writerLogs[0]);
            Assert.Equal(expectedSquareResult, writerLogs[1]);
            Assert.Equal(expectedRectangleResult, writerLogs[2]);
        }

        private decimal CalculateQuadrilateralArea(decimal height, decimal width)
        {
            return height * width;
        }

        private decimal CalculateCircleArea(decimal radius)
        {
            return radius * radius * (decimal)Math.PI;
        }
    }
}
