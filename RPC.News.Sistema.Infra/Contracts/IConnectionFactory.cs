using System.Data;

namespace RPC.News.Sistema.Infra.Contracts
{
    public interface IConnectionFactory
    {
        IDbConnection Connection();
    }
}
