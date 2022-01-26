using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.Business.Models.Clientes.Services
{
    public interface IClienteService : IDisposable
    {
        Task<Cliente> ObterPorId(Guid clienteId);
    }
}
