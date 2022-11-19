using System;

namespace DiagramAnalysisTest
{
    public class Circle 
    {
        public decimal Radius { get; set; }
        public decimal Area => (decimal)Math.PI * Radius * Radius;
    }
}
