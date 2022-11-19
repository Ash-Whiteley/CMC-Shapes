using System.Threading.Tasks;

namespace ShapesTest.Interfaces
{
    public interface IWriterAsync
    {
        /// <summary>
        /// Perform an asynchronous write operation.
        /// </summary>
        /// <param name="message">A <see cref="string"/> message to display in the console.</param>
        /// <returns><see cref="Task"/> representing the asynchronous operation.</returns>
        ValueTask WriteAsync(string message);
    }
}
