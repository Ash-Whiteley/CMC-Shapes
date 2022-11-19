using System.Threading.Tasks;
using ShapesTest.Interfaces;

namespace ShapesTest.Shapes.Helpers
{
    /// <summary>
    /// Responsible for displaying the area for a number of shapes.
    /// </summary>
    public class AreaDisplay : IDisplay
    {
        private readonly IWriter displayWriter;

        public AreaDisplay(IWriter writer)
        {
            displayWriter = writer;
        }

        public IWriter Writer { get => displayWriter; }

        /// <summary>
        /// Prints the areas of objects which implement <see cref="IShape"/>.
        /// </summary>
        /// <param name="shapes">A <see cref="object[]"/> containing shapes to display the area for.</param>
        /// <returns><see cref="ValueTask"/></returns>
        public async ValueTask DisplayAsync(params object[] shapes)
        {
            foreach (var shape in shapes)
            {
                if (shape is IShape s)
                {
                    await displayWriter.WriteAsync($"{s.Area}");
                }
            }
        }
    }
}
