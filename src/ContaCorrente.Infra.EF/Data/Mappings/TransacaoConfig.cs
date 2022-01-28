using ContaCorrente.Business.Models.Contas;
using ContaCorrente.Business.Models.Transacoes;
using ContaCorrente.Infra.EF.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContaCorrente.Infra.EF.Data.Mappings
{
    internal class TransacaoConfig : DbEntityConfiguration<Transacao>
    {
        public override void Configure(EntityTypeBuilder<Transacao> entity)
        {
            entity.ToTable("Transacoes");
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Valor).IsRequired();
            entity.Property(c => c.Data).IsRequired().HasDefaultValueSql("getdate()");
            entity.HasOne<Conta>().WithMany().HasForeignKey(c => c.ContaId).OnDelete(DeleteBehavior.NoAction).IsRequired();
        }
    }
}