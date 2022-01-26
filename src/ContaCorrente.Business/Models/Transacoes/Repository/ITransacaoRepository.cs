using ContaCorrente.Business.Core.Data;

namespace ContaCorrente.Business.Models.Transacoes.Repository
{
    public interface ITransacaoRepository : IQueryableRepository<Transacao>, ITransactionalRepository<Transacao>
    {
    }
}