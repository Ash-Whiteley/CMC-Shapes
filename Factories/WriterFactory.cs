using DiagramAnalysisTest.Classes;

namespace DiagramAnalysisTest.Factories
{
    /// <summary>
    /// Responsible for displaying the area for a number of shapes.
    /// </summary>
    public static class WriterFactory
    {
        public static Printer CreatePrinter()
        {
            return new Printer();
        }
    }
}
