using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.Business.Models.Transacoes.Validations
{
    public class TransacaoValidation : AbstractValidator<Transacao>
    {
        public TransacaoValidation()
        {
            RuleFor(t => t.Valor)
                .GreaterThan(0).WithMessage("A transação deve possuir um valor válido. Valor informado: {PropertyValue}");
        }
    }
}
