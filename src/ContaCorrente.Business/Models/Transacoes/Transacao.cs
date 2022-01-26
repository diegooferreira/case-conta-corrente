using ContaCorrente.Business.Core.Models;
using ContaCorrente.Business.Models.Contas;
using ContaCorrente.Business.Models.Transacoes.Enums;
using System;

namespace ContaCorrente.Business.Models.Transacoes
{
    public class Transacao : Entity
    {
        public TipoTransacao Tipo { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public Conta Conta { get; set; }
    }
}
