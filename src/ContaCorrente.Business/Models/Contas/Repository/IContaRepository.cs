using ContaCorrente.Business.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.Business.Models.Contas.Repository
{
    public interface IContaRepository : IQueryableRepository<Conta>, ITransactionalRepository<Conta>
    {

    }
}
