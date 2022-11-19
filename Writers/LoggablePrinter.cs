using DiagramAnalysisTest.Interfaces;
using System.Collections.Generic;

namespace ShapesTest.Writers
{
    public class LoggablePrinter : Printer, ILoggableWriter
    {
        private readonly List<string> logs = new List<string>();

        public List<string> Logs { get => logs; }

        /// <summary>
        /// Print a message to the console synchronously.
        /// </summary>
        /// <param name="message">A <see cref="string"/> message to display in the console.</param>
        public override void Write(string message)
        {
            base.Write(message);

            this.Log(message);
        }

        /// <inheritdoc/>
        public void Log(string message)
        {
            this.logs.Add(message);
        }
    }
}
