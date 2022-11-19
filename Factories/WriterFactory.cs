using ShapesTest.Writers;

namespace ShapesTest.Factories
{
    /// <summary>
    /// Factory responsible for creating a number of different writer classes
    /// </summary>
    public static class WriterFactory
    {
        /// <summary>
        /// Factory method for creating a <see cref="Printer"/>. This does not support logging.
        /// </summary>
        /// <returns>A <see cref="Printer"/> instance.</returns>
        public static Printer CreatePrinter()
        {
            return new Printer();
        }

        /// <summary>
        /// Factory method for creating a <see cref="Printer"/>. This printer type keeps a log of written messages.
        /// </summary>
        /// <returns>A <see cref="LoggablePrinter"/> instance.</returns>
        public static Printer CreateLoggablePrinter()
        {
            return new LoggablePrinter();
        }
    }
}
