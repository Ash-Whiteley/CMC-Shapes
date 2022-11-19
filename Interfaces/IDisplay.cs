using System.Threading.Tasks;

namespace ShapesTest.Interfaces
{
    public interface IDisplay
    {
        /// <summary>
        /// Asynchronously display a list of objects.
        /// </summary>
        /// <param name="obj">The list of objects to display.</param>
        /// <returns><see cref="ValueTask"/></returns>
        ValueTask DisplayAsync(params object[] obj);
    }
}
