using DiagramAnalysisTest.Interfaces;

namespace DiagramAnalysisTest.Factories
{
    /// <summary>
    /// Factory responsible for creating classes that display information
    /// </summary>
    public static class DisplayFactory
    {
        /// <summary>
        /// Factory method for creating a <see cref="AreaDisplay"/>. Will utilise <see cref="ShapesTest.Writers.Printer"/>
        /// </summary>
        /// <returns>A <see cref="AreaDisplay"/> instance.</returns>
        public static AreaDisplay CreateAreaDisplay()
        {
            return new AreaDisplay(WriterFactory.CreatePrinter());
        }

        /// <summary>
        /// Factory method for creating a <see cref="AreaDisplay"/> class for a provided <see cref="IWriter"/> implementation.
        /// </summary>
        /// <param name="writer">The <see cref="IWriter"/> implementation to be used.</param>
        /// <returns>A <see cref="AreaDisplay"/> instance.</returns>
        public static AreaDisplay CreateAreaDisplay(IWriter writer)
        {
            return new AreaDisplay(writer);
        }
    }
}
