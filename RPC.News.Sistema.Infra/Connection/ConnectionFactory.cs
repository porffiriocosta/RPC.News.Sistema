using RPC.News.Sistema.Infra.Contracts;
using System.Data;
using System.Data.SqlClient;

namespace RPC.News.Sistema.Infra.Connection
{
    public class ConnectionFactory : IConnectionFactory
    {
        public IDbConnection Connection()
        {
            return new SqlConnection("Data Source=Reginaldo-PC;Initial Catalog=RPC.News.Sistema;Integrated Security=True");
        }
    }
}
