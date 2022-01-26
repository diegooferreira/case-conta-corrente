using ContaCorrente.Business.Core.Errors;
using ContaCorrente.Business.Core.Services;
using ContaCorrente.Business.Models.Clientes.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.Business.Models.Clientes.Services
{
    public class ClienteService : BaseService, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(INotificator notificator,
            IClienteRepository clienteRepository) : base(notificator)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<Cliente> ObterPorId(Guid clienteId)
        {
            return await _clienteRepository.GetById(clienteId);
        }

        public void Dispose()
        {
            _clienteRepository?.Dispose();
        }
    }
}
