using RPC.News.Sistema.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RPC.News.Sistema.Application.Contracts
{
    public interface IClienteEntityService
    {
        Task<IEnumerable<ClienteEntity>> GetClientes();
    }
}
