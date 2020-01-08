namespace Application.Boundaries
{
    /// <summary>
    /// Not Found Output Port.
    /// </summary>
    public interface IOutputPortNotFound
    {
        /// <summary>
        /// Informs the resource was not found.
        /// </summary>
        /// <param name="message">Text description.</param>
        void NotFound(string message);
    }
}
