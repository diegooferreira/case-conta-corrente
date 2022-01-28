using ContaCorrente.Business.Core.Data;
using ContaCorrente.Business.Models.Clientes.Repository;
using ContaCorrente.Business.Models.Contas.Repository;
using ContaCorrente.Business.Models.Transacoes.Repository;
using ContaCorrente.Infra.Data.Repository;
using ContaCorrente.Infra.EF.Data.Context;
using ContaCorrente.Infra.EF.Data.Repository;
using ContaCorrente.Infra.EF.Data.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.Infra.EF.DependencyInjection
{
    public class InfraConfig
    {
        public static void RegisterBindins(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IContaRepository, ContaRepository>();
            services.AddScoped<ITransacaoRepository, TransacaoRepository>();

            services.AddScoped<ITransactionalScope, TransactionalScope>();
        }

        public static void InitMigrations(IApplicationBuilder app)
        {
            DbManagementService.MigrationInit(app);
        }
    }
}
