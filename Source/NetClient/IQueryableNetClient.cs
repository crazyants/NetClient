using System.Linq;
using System.Threading.Tasks;

namespace NetClient
{
    public interface IQueryableNetClient<T> : INetClient
    {
        Task<IQueryable<T>> GetAsync();
    }
}