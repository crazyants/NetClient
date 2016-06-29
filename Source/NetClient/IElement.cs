using System;
using System.ComponentModel.Composition;
using System.Linq;

namespace NetClient
{
    /// <summary>
    ///     The NetClient element.
    /// </summary>
    /// <typeparam name="T">The type of the element.</typeparam>
    [InheritedExport]
    public interface IElement<out T> : IElement, IQueryable<T>
    {
    }

    /// <summary>
    ///     The NetClient element.
    /// </summary>
    [InheritedExport]
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