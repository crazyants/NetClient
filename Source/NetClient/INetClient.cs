using System;
using System.ComponentModel.Composition;

namespace NetClient
{
    /// <summary>
    ///     Provides a interface for sending requests and receiving responses over network boundaries.
    /// </summary>
    [InheritedExport]
    public interface INetClient
    {
        /// <summary>
        ///     Gets or sets the error action.
        /// </summary>
        /// <value>The error action.</value>
        Action<Exception> OnError { get; set; }
    }
}