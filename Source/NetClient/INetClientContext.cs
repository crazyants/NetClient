using System;
using System.Threading.Tasks;

namespace NetClient
{
    /// <summary>
    /// Interface INetClientContext
    /// </summary>
    public interface INetClientContext : IDisposable
    {
        /// <summary>
        /// Saves the asynchronous.
        /// </summary>
        /// <returns>Task.</returns>
        Task SaveAsync();
    }
}