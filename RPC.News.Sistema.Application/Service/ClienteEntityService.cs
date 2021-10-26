using RPC.News.Sistema.Application.Contracts;
using RPC.News.Sistema.Domain;
using RPC.News.Sistema.Infra.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RPC.News.Sistema.Application.Service
{

    public class ClienteEntityService : IClienteEntityService
    {
        private readonly IClienteEntityRepository _repository;

        public ClienteEntityService(IClienteEntityRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<ClienteEntity>> GetClientes()
        {
            return await _repository.GetClientes();
        }
    }
}
