using ContaCorrente.Business.Models.Transacoes;
using ContaCorrente.Business.Models.Transacoes.Repository;
using ContaCorrente.Infra.Data.Repository;
using ContaCorrente.Infra.EF.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.Infra.EF.Data.Repository
{
    public class TransacaoRepository : Repository<Transacao>, ITransacaoRepository
    {
        public TransacaoRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}