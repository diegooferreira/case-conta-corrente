using ContaCorrente.Business.Models.Transacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.Business.Models.Contas.Service
{
    public interface IContaService : IDisposable
    {
        Task<Conta> ObterPorId(Guid id);
        Task<IEnumerable<Transacao>> ObterTransacoesDaConta(Guid contaId);
        Task AtualizarSaldo(Guid contaId, decimal valor);
    }
}
