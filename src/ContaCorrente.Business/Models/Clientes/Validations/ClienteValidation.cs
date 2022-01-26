using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.Business.Models.Clientes.Validations
{
    public class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {
            RuleFor(t => t.Nome)
                .NotEmpty().WithMessage("O cliente deve possuir um nome válido.");

            RuleFor(t => t.Documento)
                .NotEmpty().WithMessage("O cliente deve possuir um documento válido.");
        }
    }
}