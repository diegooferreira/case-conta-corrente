using ContaCorrente.Business.Core.Models;
using ContaCorrente.Business.Models.Transacoes.Enums;
using System;

namespace ContaCorrente.Business.Models.Transacoes
{
    public class Transacao : Entity
    {
        public Transacao()
        {
            Id= Guid.NewGuid();
        }

        public Transacao(TipoTransacao tipo, decimal valor, Guid contaId)
        {
            Id = Guid.NewGuid();
            Tipo = tipo;
            Data = DateTime.Now;
            Valor = valor;
            ContaId = contaId;
        }

        public Transacao(Guid id, TipoTransacao tipo, decimal valor, Guid contaId)
        {
            Id = id;
            Tipo = tipo;
            Data = DateTime.Now;
            Valor = valor;
            ContaId = contaId;
        }

        public TipoTransacao Tipo { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public Guid ContaId { get; set; }
    }
}
