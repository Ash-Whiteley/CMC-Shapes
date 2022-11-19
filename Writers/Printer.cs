using ShapesTest.Interfaces;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ShapesTest.Writers
{
    public class Printer : IWriter
    {
        /// <summary>
        /// Print a message to the console synchronously.
        /// </summary>
        /// <param name="message">A <see cref="string"/> message to display in the console.</param>
        public virtual void Write(string message)
        {
            // This would go to a printer, but for demo purposes, we write to the Debug console
            Debug.WriteLine(message);
        }

        /// <summary>
        /// Print a message to the console asynchronously.
        /// </summary>
        /// <param name="message">A <see cref="string"/> message to display in the console.</param>
        /// <returns><see cref="Task"/> representing the asynchronous operation.</returns>
        public async ValueTask WriteAsync(string message)
        {
            await Task.Run(() => Write(message));
        }
    }
}
