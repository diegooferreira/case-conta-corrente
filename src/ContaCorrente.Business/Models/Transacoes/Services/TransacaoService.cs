using ContaCorrente.Business.Core.Data;
using ContaCorrente.Business.Core.Errors;
using ContaCorrente.Business.Core.Services;
using ContaCorrente.Business.Models.Contas;
using ContaCorrente.Business.Models.Contas.Service;
using ContaCorrente.Business.Models.Contas.Validation;
using ContaCorrente.Business.Models.Transacoes.Repository;
using ContaCorrente.Business.Models.Transacoes.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaCorrente.Business.Models.Transacoes.Services
{
    public class TransacaoService : BaseService, ITransacaoService
    {
        private readonly IContaService _contaService;
        private readonly ITransacaoRepository _transacaoRepository;
        private readonly ITransactionalScope _transactionalScope;

        public TransacaoService(ITransacaoRepository transacaoRepository,
            IContaService contaService,
            ITransactionalScope transactionalScope,
            INotificator notificator) : base(notificator)
        {
            _transacaoRepository = transacaoRepository;
            _contaService = contaService;
            _transactionalScope = transactionalScope;
        }

        public async Task Adicionar(Transacao transacao)
        {
            var isTransacaoValid = await IsModelValid<TransacaoValidation, Transacao>(transacao);

            if (!isTransacaoValid)
            {
                return;
            }

            //var isContaValid = await IsModelValid<ContaValidation, Conta>(transacao.Conta);

            //if (!isContaValid)
            //{
            //    return;
            //}

            await _transactionalScope.Open();

            try
            {
                // Registra a transação
                await _transacaoRepository.Insert(transacao);

                // Atualiza o saldo
                await _contaService.AtualizarSaldo(transacao.ContaId,
                    transacao.Valor * (transacao.Tipo == Enums.TipoTransacao.Debito ? -1 : 1));

                await _transactionalScope.Complete();
            }
            catch (Exception ex)
            {
                await _transactionalScope.RevertChanges();

                await NotifyError(ex.Message);
            }
        }

        public async Task<IEnumerable<Transacao>> ObterTransacoesDaConta(Guid contaId)
        {
            var result = await _transacaoRepository.Search(t => t.ContaId == contaId);
            return result.OrderByDescending(o => o.Data);
        }

        public void Dispose()
        {
            _transacaoRepository?.Dispose();
            _transactionalScope?.Dispose();
            _contaService?.Dispose();
        }
    }
}
