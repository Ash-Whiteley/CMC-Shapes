using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace DiagramAnalysisTest
{
    public class Printer
    {
        public void Print(string message)
        {
            // this would go to a printer, but for demo purposes, we write to the Debug console
            Debug.WriteLine(message);
        }

        public async Task PrintAsync(string message)
        {
            await Task.Run(() => Print(message));
        }
    }
}
