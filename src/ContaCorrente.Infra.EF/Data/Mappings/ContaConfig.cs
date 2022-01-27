using ContaCorrente.Business.Models.Clientes;
using ContaCorrente.Business.Models.Contas;
using ContaCorrente.Business.Models.Transacoes;
using ContaCorrente.Infra.EF.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContaCorrente.Infra.EF.Data.Mappings
{
    internal class ContaConfig : DbEntityConfiguration<Conta>
    {
        public override void Configure(EntityTypeBuilder<Conta> entity)
        {
            entity.ToTable("Contas");
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Agencia).IsRequired().HasMaxLength(5);
            entity.Property(c => c.Numero).IsRequired().HasMaxLength(6);
        }
    }
}