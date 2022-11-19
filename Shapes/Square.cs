namespace DiagramAnalysisTest
{
    public class Square : Rectangle
    {
        private decimal height;
        private decimal width;
        public override decimal Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
                width = value;
            }
        }
        public override decimal Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                height = value;
            }
        }
    }
}
