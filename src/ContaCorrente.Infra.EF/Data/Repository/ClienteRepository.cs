using ContaCorrente.Business.Models.Clientes;
using ContaCorrente.Business.Models.Clientes.Repository;
using ContaCorrente.Infra.Data.Repository;
using ContaCorrente.Infra.EF.Data.Context;
using System.Linq.Expressions;

namespace ContaCorrente.Infra.EF.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
