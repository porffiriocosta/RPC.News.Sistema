using System;

namespace RPC.News.Sistema.Domain
{
    public class ClienteEntity
    {
        public string NomeCliente { get; set; }
        public string CpfCliente { get; set; }
        public int IdadeCliente { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastroCliente { get; set; }
    }
}
