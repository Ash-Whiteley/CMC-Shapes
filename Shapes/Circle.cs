using System;

namespace DiagramAnalysisTest.Shapes
{
    public class Circle : Interfaces.ICircle
    {
        /// <summary>
        /// Gets or sets a value denoting the radius of the circular shape.
        /// </summary>
        public decimal Radius { get; set; }

        /// <inheritdoc/>
        public decimal Area => (decimal)Math.PI * Radius * Radius;
    }
}
