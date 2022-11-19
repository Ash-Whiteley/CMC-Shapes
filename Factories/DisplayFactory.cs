using DiagramAnalysisTest.Interfaces;

namespace DiagramAnalysisTest.Factories
{
    /// <summary>
    /// Factory responsible for creating classes that display information
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
