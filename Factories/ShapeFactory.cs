using DiagramAnalysisTest.Shapes;

namespace DiagramAnalysisTest.Factories
{
    /// <summary>
    /// Responsible for displaying the area for a number of shapes.
    /// </summary>
    public static class ShapeFactory
    {
        /// <summary>
        /// Factory method for creating a <see cref="Circle"/>.
        /// </summary>
        /// <param name="radius">The radius of the circle to be initialised.</param>
        /// <returns>A <see cref="Circle"/> instance.</returns>
        public static Circle CreateCircle(decimal radius)
        {
            return new Circle
            {
                Radius = radius,
            };
        }

        /// <summary>
        /// Factory method for creating a <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="height">The height of the rectangle to be initialised.</param>
        /// <param name="width">The width of the rectangle to be initialised.</param>
        /// <returns>A <see cref="Rectangle"/> instance.</returns>
        public static Rectangle CreateRectangle(decimal height, decimal width)
        {
            return new Rectangle
            {
                Height = height,
                Width = width
            };
        }

        /// <summary>
        /// Factory method for creating a <see cref="Square"/>.
        /// </summary>
        /// <param name="length">The length of the sides on the square.</param>
        /// <returns>A <see cref="Square"/>.</returns>
        public static Square CreateSquare(decimal length)
        {
            return new Square
            {
                Length = length,
            };
        }
    }
}
