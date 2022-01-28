using ContaCorrente.Business.Core.Models;
using ContaCorrente.Business.Models.Clientes;
using System;

namespace ContaCorrente.Business.Models.Contas
{
    public class Conta : Entity
    {
        public Conta(Guid id, Guid clienteId, int agencia, int numero)
        {
            Id = id;
            ClienteId = clienteId;
            Agencia = agencia;
            Numero = numero;
            Saldo = 0m;
        }

        public Conta()
        {
            Id = Guid.NewGuid();
        }

        public Guid ClienteId { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public decimal Saldo { get; set; }
    }
}
