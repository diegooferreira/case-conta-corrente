using ContaCorrente.Business.Core.Models;
using ContaCorrente.Business.Models.Contas;
using System;

namespace ContaCorrente.Business.Models.Clientes
{
    public class Cliente : Entity
    {
        public Cliente()
        {
            Id = Guid.NewGuid();
        }

        public Cliente(string nome, string documento)
        {
            Nome = nome;
            Documento = documento;  
        }

        public Cliente(Guid id, string nome, string documento)
        {
            Id = id;
            Nome = nome;
            Documento = documento;
        }

        public string Nome { get; set; }
        public string Documento { get; set; }
    }
}
