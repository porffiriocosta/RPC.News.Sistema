using RPC.News.Sistema.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RPC.News.Sistema.Infra.Contracts
{
    public interface IClienteEntityRepository
    {
        Task<IEnumerable<ClienteEntity>> GetClientes();
    }
}
