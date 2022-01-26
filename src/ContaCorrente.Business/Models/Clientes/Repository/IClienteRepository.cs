using ContaCorrente.Business.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.Business.Models.Clientes.Repository
{
    public interface IClienteRepository : IQueryableRepository<Cliente>
    {
    }
}
