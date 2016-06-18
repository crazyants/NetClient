using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetClient
{
    /// <summary>
    /// Interface IChangeableNetClient
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IChangeableNetClient<T> : INetClient
    {
        /// <summary>
        /// Adds asynchronously.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        Task<T> AddAsync(T item);

        /// <summary>
        /// Adds asynchronously.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns>Task&lt;IEnumerable&lt;T&gt;&gt;.</returns>
        Task<IEnumerable<T>> AddAsync(IEnumerable<T> items);

        /// <summary>
        /// Deletes asynchronously.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        Task<T> DeleteAsync(T item);

        /// <summary>
        /// Deletes asynchronously.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns>Task&lt;IEnumerable&lt;T&gt;&gt;.</returns>
        Task<IEnumerable<T>> DeleteAsync(IEnumerable<T> items);

        /// <summary>
        /// Edits asynchronously.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        Task<T> EditAsync(T item);

        /// <summary>
        /// Edits asynchronously.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns>Task&lt;IEnumerable&lt;T&gt;&gt;.</returns>
        Task<IEnumerable<T>> EditAsync(IEnumerable<T> items);
    }
}