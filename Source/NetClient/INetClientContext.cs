using System;
using System.Threading.Tasks;

namespace NetClient
{
    public interface INetClientContext : IDisposable
    {
        Task SaveAsync();
    }
}