using Dapper;
using RPC.News.Sistema.Domain;
using RPC.News.Sistema.Infra.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPC.News.Sistema.Infra.Repository
{
    public class ClienteEntityRepository : IClienteEntityRepository
    {
        private readonly IConnectionFactory _connection;
        public ClienteEntityRepository(IConnectionFactory connection)
        {
            _connection = connection;
        }
        public async Task<IEnumerable<ClienteEntity>> GetClientes()
        {
            string sql = "select * from ClienteEntity";

            IList<ClienteEntity> listCliente = new List<ClienteEntity>();

            using (var connectionDb = _connection.Connection())
            {
                connectionDb.Open();

                var result = await connectionDb.QueryAsync<dynamic>(sql);

                if (result.Any())
                {
                    foreach (var item in result.ToList())
                    {
                       var cliente = new ClienteEntity();

                        cliente.NomeCliente = item.NomeCliente;
                        cliente.CpfCliente = item.CpfCliente;
                        cliente.IdadeCliente = item.IdadeCliente;
                        cliente.Ativo = item.Ativo;
                        cliente.DataCadastroCliente = item.DataCadastroCliente;

                        listCliente.Add(cliente);
                    }
                }
            }
            return listCliente;
        }
    }
}
