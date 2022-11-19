namespace DiagramAnalysisTest.Shapes
{
    public class Rectangle : Interfaces.IShape
    {
        /// <summary>
        /// Gets or sets a value indicating the <see cref="decimal"/> height of the rectangle.
        /// </summary>
        public decimal Height { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the <see cref="decimal"/> width of the rectangle.
        /// </summary>
        public decimal Width { get; set; }

        /// <inheritdoc/>
        public decimal Area => Height * Width;
    }
}