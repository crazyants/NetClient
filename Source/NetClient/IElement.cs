using System;
using System.Linq;

namespace NetClient
{
    /// <summary>
    ///     The NetClient element.
    /// </summary>
    /// <typeparam name="T">Type of element.</typeparam>
    public interface IElement<out T> : IQueryable<T>
    {
        /// <summary>
        ///     Gets the client.
        /// </summary>
        /// <value>The client.</value>
        INetClient Client { get; }

        /// <summary>
        ///     Gets or sets the error action.
        /// </summary>
        /// <value>The error action.</value>
        Action<Exception> OnError { get; set; }
    }
}