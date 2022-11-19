using System.Collections.Generic;

namespace DiagramAnalysisTest.Interfaces
{
    public interface ILoggableWriter : IWriter
    {
        /// <summary>
        /// A list of messages the writer previously logged.
        /// </summary>
        List<string> Logs { get; }

        /// <summary>
        /// Log the provided message.
        /// </summary>
        /// <param name="message">A <see cref="string"/> message to log.</param>
        void Log(string message);
    }
}
