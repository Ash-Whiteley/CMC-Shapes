using System.Threading.Tasks;
using DiagramAnalysisTest.Interfaces;

namespace DiagramAnalysisTest
{
    /// <summary>
    /// Responsible for displaying the area for a number of shapes.
    /// </summary>
    public class AreaDisplay
    {
        public async ValueTask DisplayAsync(params object[] shapes)
        {
            foreach (var shape in shapes)
            {
                var printer = new Printer();

                if (shape is Rectangle)
                {
                    await printer.PrintAsync(((Rectangle)shape).Area.ToString());
                }

                if (shape is Circle)
                {
                    await printer.PrintAsync(((Circle)shape).Area.ToString());
                }
            }
        }
    }
}
