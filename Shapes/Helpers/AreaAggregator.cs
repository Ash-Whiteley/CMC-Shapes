using ShapesTest.Interfaces;

namespace ShapesTest.Shapes.Helpers
{
    /// <summary>
    /// Responsible for aggregating the area for a number of shapes.
    /// </summary>
    public static class AreaAggregator
    {
        /// <summary>
        /// Calculates the sum of objects provided that implement <see cref="Interfaces.IShape"/>.
        /// </summary>
        /// <param name="shapes"></param>
        /// <returns>A <see cref="decimal"/> representing the area of the shapes.</returns>
        public static decimal SumArea(params object[] shapes)
        {
            var areaTotal = 0M;

            foreach (var shape in shapes)
            {
                // Detect if the object is a valid shape.
                if (shape is IShape s)
                {
                    areaTotal += s.Area;
                }
            }

            return areaTotal;
        }
    }
}
