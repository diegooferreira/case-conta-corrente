using ContaCorrente.Business.Core.Models;
using ContaCorrente.Business.Models.Clientes;

namespace ContaCorrente.Business.Models.Contas
{
    public class Conta : Entity
    {
        public Cliente Cliente { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public decimal Saldo { get; set; }
    }
}
