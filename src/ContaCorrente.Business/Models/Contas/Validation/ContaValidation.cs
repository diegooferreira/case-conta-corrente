using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.Business.Models.Contas.Validation
{
    public class ContaValidation : AbstractValidator<Conta>
    {
        public ContaValidation()
        {
            RuleFor(c => c.Agencia)
                .GreaterThan(0).WithMessage("A conta deve possuir uma agência válida. Valor informado: {PropertyValue}");

            RuleFor(c => c.Numero)
                .GreaterThan(0).WithMessage("A conta deve possuir um número válido. Valor informado: {PropertyValue}");
        }
    }
}
