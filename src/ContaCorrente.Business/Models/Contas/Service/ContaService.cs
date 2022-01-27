﻿using ContaCorrente.Business.Core.Errors;
using ContaCorrente.Business.Core.Services;
using ContaCorrente.Business.Models.Contas.Repository;
using ContaCorrente.Business.Models.Transacoes;
using ContaCorrente.Business.Models.Transacoes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.Business.Models.Contas.Service
{
    public class ContaService : BaseService, IContaService
    {
        private readonly ITransacaoService _transacaoService;
        private readonly IContaRepository _contaRepository;

        public ContaService(INotificator notificator,
            ITransacaoService transacaoService,
            IContaRepository contaRepository) : base(notificator)
        {
            _transacaoService = transacaoService;
            _contaRepository = contaRepository;
        }

        public async Task<Conta> ObterPorId(Guid id)
        {
            return await _contaRepository.GetById(id);
        }

        public async Task<IEnumerable<Transacao>> ObterTransacoesDaConta(Guid contaId)
        {
            return await _transacaoService.ObterTransacoesDaConta(contaId);
        }

        public async Task AtualizarSaldo(Guid contaId, decimal valor)
        {
            var conta = await _contaRepository.GetById(contaId);
            conta.Saldo += valor;
            await _contaRepository.Update(conta);
            await _contaRepository.SaveChanges();
        }

        public void Dispose()
        {
            _contaRepository?.Dispose();
            _transacaoService?.Dispose();
        }
    }
}
