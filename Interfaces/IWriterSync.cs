namespace ShapesTest.Interfaces
{
    public interface IWriterSync
    {
        /// <summary>
        /// Perform a synchronise write operation.
        /// </summary>
        /// <param name="message"></param>
        void Write(string message);
    }
}
