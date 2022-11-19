using System.Threading.Tasks;
using DiagramAnalysisTest.Interfaces;

namespace DiagramAnalysisTest
{
    /// <summary>
    /// Responsible for displaying the area for a number of shapes.
    /// </summary>
    public class AreaDisplay
    {
        /// <summary>
        /// Prints the areas of objects which implement <see cref="IShape"/>.
        /// </summary>
        /// <param name="shapes">A <see cref="object[]"/> containing shapes to display the area for.</param>
        /// <returns><see cref="ValueTask"/></returns>
        public async ValueTask DisplayAsync(params object[] shapes)
        {
            foreach (var shape in shapes)
            {
                var printer = new Printer();

                if (shape is IShape s)
                {
                    await printer.PrintAsync(s.Area.ToString());
                }
            }
        }
    }
}
