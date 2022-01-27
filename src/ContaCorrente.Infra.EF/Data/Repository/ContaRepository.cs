using ContaCorrente.Business.Models.Contas;
using ContaCorrente.Business.Models.Contas.Repository;
using ContaCorrente.Infra.Data.Repository;
using ContaCorrente.Infra.EF.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.Infra.EF.Data.Repository
{
    public class ContaRepository : Repository<Conta>, IContaRepository
    {
        public ContaRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
