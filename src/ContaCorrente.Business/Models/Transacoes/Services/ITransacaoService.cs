using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.Business.Models.Transacoes.Services
{
    public interface ITransacaoService : IDisposable
    {
        Task Adicionar(Transacao transacao);
        Task<IEnumerable<Transacao>> ObterTransacoesDaConta(Guid contaId);
    }
}
