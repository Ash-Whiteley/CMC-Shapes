using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiagramAnalysisTest
{
    public static class AreaAggregator
    {
        public static decimal SumArea(params object[] shapes)
        {
            decimal retVal = 0;

            foreach (var shape in shapes)
            {
                if (shape is Rectangle)
                {
                    retVal += ((Rectangle)shape).Area;
                }

                if (shape is Circle)
                {
                    retVal += ((Circle)shape).Area;
                }
            }

            return retVal;
        }

        public static async Task PrintAreasAsync(params object[] shapes)
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
