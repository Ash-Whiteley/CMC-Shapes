namespace DiagramAnalysisTest.Shapes
{
    public class Square : Interfaces.IShape
    {
        /// <summary>
        /// Gets a value indicating the length of the square for each side.
        /// </summary>
        public decimal Length { get; set; }

        /// <inheritdoc/>
        public decimal Area => Length * Length;
    }
}
