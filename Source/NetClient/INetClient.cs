namespace NetClient
{
    /// <summary>
    /// Interface INetClient
    /// </summary>
    public interface INetClient
    {
        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        /// <value>The context.</value>
        INetClientContext Context { get; set; }
    }
}