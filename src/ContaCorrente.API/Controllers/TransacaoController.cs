using ContaCorrente.Business.Models.Contas.Service;
using ContaCorrente.Business.Models.Transacoes;
using ContaCorrente.Business.Models.Transacoes.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ContaCorrente.API.Controllers
{
    [Route("api/transacao")]
    [ApiController]
    public class TransacaoController : ControllerBase
    {
        private readonly ITransacaoService _transacaoService;
        private readonly IContaService _contaService;

        public TransacaoController(ITransacaoService transacaoService, IContaService contaService)
        {
            _transacaoService = transacaoService;
            _contaService = contaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTransacao()
        {
            //var trans = new Transacao()
            //{
            //    Tipo = Business.Models.Transacoes.Enums.TipoTransacao.Credito,
            //    Valor = 100m,
            //    Conta = new Business.Models.Contas.Conta { Id = Guid.Parse("603AA6D3-7B3B-4439-91F8-16D918717777") }
            //};

            //await _transacaoService.Adicionar(trans);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> PostTransacao(Transacao transacao)
        {
            // var conta = await _contaService.ObterPorId(Guid.Parse("603AA6D3-7B3B-4439-91F8-16D918717777"));

            //var trans = new Transacao()
            //{
            //    Tipo = Business.Models.Transacoes.Enums.TipoTransacao.Credito,
            //    Valor = 100m,
            //    Conta = conta
            //};

            var trans = new Transacao(Business.Models.Transacoes.Enums.TipoTransacao.Debito,
                50m, Guid.Parse("603AA6D3-7B3B-4439-91F8-16D918717777")
            );

            await _transacaoService.Adicionar(trans);

            return Ok();
        }
    }
}
