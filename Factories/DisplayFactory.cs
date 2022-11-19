using DiagramAnalysisTest.Interfaces;

namespace DiagramAnalysisTest.Factories
{
    /// <summary>
    /// Responsible for displaying the area for a number of shapes.
    /// </summary>
    public static class DisplayFactory
    {
        public static AreaDisplay CreateAreaDisplay()
        {
            return new AreaDisplay(WriterFactory.CreatePrinter());
        }

        public static AreaDisplay CreateAreaDisplay(IWriter writer)
        {
            return new AreaDisplay(writer);
        }
    }
}
