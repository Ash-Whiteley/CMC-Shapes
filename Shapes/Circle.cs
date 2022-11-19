using System;

namespace ShapesTest.Shapes
{
    public class Circle : Interfaces.IShape
    {
        private decimal radius;

        /// <summary>
        /// Gets or sets a value denoting the <see cref="decimal"/> radius of the circular shape.
        /// </summary>
        public decimal Radius
        {
            get => this.radius;
            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentOutOfRangeException("The supplied radius cannot be negative");
                }

                this.radius = value;
            }
        }

        /// <inheritdoc/>
        public decimal Area => (decimal)Math.PI * Radius * Radius;
    }
}
