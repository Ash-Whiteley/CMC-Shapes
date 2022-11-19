using DiagramAnalysisTest.Classes;

namespace DiagramAnalysisTest.Factories
{
    /// <summary>
    /// Factory responsible for creating a number of different writer classes
    /// </summary>
    public static class WriterFactory
    {
        public static Printer CreatePrinter()
        {
            return new Printer();
        }

        public static Printer CreateLoggablePrinter()
        {
            return new LoggablePrinter();
        }
    }
}
