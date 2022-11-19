namespace ShapesTest.Shapes
{
    public class Rectangle : Interfaces.IShape
    {
        private decimal height;
        private decimal width;

        /// <summary>
        /// Gets or sets a value indicating the <see cref="decimal"/> height of the rectangle.
        /// </summary>
        public decimal Height
        {
            get => this.height;
            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentOutOfRangeException("The supplied height cannot be negative");
                }

                this.height = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating the <see cref="decimal"/> width of the rectangle.
        /// </summary>
        public decimal Width
        {
            get => this.width;
            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentOutOfRangeException("The supplied width cannot be negative");
                }

                this.width = value;
            }
        }

        /// <inheritdoc/>
        public decimal Area => Height * Width;
    }
}