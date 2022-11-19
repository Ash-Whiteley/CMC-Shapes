namespace ShapesTest.Shapes
{
    public class Square : Interfaces.IShape
    {
        private decimal length;

        /// <summary>
        /// Gets a value indicating the <see cref="decimal"/> length of the square for each side.
        /// </summary>
        public decimal Length 
        {
            get => this.length;
            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentOutOfRangeException("The supplied length cannot be negative");
                }

                this.length = value;
            }
        }

        /// <inheritdoc/>
        public decimal Area => Length * Length;
    }
}
