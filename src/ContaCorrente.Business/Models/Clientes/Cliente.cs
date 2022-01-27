using ContaCorrente.Business.Core.Models;
using ContaCorrente.Business.Models.Contas;

namespace ContaCorrente.Business.Models.Clientes
{
    public class Cliente : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
    }
}
