using System.Linq;
using System.Threading.Tasks;

namespace NetClient
{
    /// <summary>
    /// Interface IQueryableNetClient
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IQueryableNetClient<T> : INetClient
    {
        /// <summary>
        /// Gets asynchronously.
        /// </summary>
        /// <returns>Task&lt;IQueryable&lt;T&gt;&gt;.</returns>
        Task<IQueryable<T>> GetAsync();
    }
}