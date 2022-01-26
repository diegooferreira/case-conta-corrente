using ContaCorrente.Business.Core.Models;

namespace ContaCorrente.Business.Models.Clientes
{
    public class Cliente : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
    }
}
