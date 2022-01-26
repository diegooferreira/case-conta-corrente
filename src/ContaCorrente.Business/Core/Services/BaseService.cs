using ContaCorrente.Business.Core.Errors;
using ContaCorrente.Business.Core.Models;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.Business.Core.Services
{
    public abstract class BaseService
    {
        private readonly INotificator _notificator;

        protected BaseService(INotificator notificator)
        {
            _notificator = notificator;
        }

        protected async Task<bool> IsModelValid<TValidator, TEntity>(TEntity entidade)
            where TValidator : AbstractValidator<TEntity> where TEntity : Entity
        {
            var validator = Activator.CreateInstance<TValidator>();
            var validationResult = await validator.ValidateAsync(entidade);

            if (validationResult.IsValid) return true;

            await NotifyError(validationResult);

            return false;
        }

        protected async Task NotifyError(string message)
        {
            _notificator.Handle(new Error(message));
        }

        private async Task NotifyError(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                await NotifyError(error.ErrorMessage);
            }
        }
    }
}
