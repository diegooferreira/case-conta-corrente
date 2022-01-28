using ContaCorrente.Business.Core.Data;
using ContaCorrente.Business.Core.Errors;
using ContaCorrente.Business.Models.Clientes.Services;
using ContaCorrente.Business.Models.Contas.Service;
using ContaCorrente.Business.Models.Transacoes.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.Business.DependencyInjection
{
    public class BusinessConfig
    {
        public static void RegisterBindins(IServiceCollection services)
        {
            services.AddScoped<INotificator, Notificator>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IContaService, ContaService>();
            services.AddScoped<ITransacaoService, TransacaoService>();
        }
    }
}
