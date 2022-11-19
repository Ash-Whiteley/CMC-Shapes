namespace DiagramAnalysisTest
{
    public class Rectangle
    {
        public virtual decimal Height { get; set; }
        public virtual decimal Width { get; set; }
        public virtual decimal Area => Height * Width;
    }
}
