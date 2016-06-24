using System;
using System.Linq;

namespace NetClient
{
    /// <summary>
    ///     The NetClient element.
    /// </summary>
    /// <typeparam name="T">The type of the element.</typeparam>
    /// <typeparam name="TCriteria">The type of the criteria.</typeparam>
    public interface IElement<out T, out TCriteria> : IElement, IQueryable<T>
    {
        /// <summary>
        ///     Gets the criteria.
        /// </summary>
        /// <value>The criteria.</value>
        TCriteria Criteria { get; }
    }

    /// <summary>
    ///     The NetClient element.
    /// </summary>
    /// <typeparam name="T">The type of the element.</typeparam>
    public interface IElement<out T> : IElement, IQueryable<T>
    {
    }

    /// <summary>
    ///     The NetClient element.
    /// </summary>
    public interface IElement
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