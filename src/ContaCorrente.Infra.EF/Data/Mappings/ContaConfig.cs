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
            entity.HasOne<Cliente>().WithMany().HasForeignKey(c => c.ClienteId).OnDelete(DeleteBehavior.NoAction).IsRequired();

            entity.HasData(new
            {
                Id = Guid.Parse("603AA6D3-7B3B-4439-91F8-16D918717777"),
                ClienteId = Guid.Parse("BC948E10-BFED-4F7A-B26A-ACFE6E2D51B1"),
                Agencia = 1,
                Numero = 1,
                Saldo = 0m
            }, new
            {
                Id = Guid.Parse("8E62620B-9DF4-43BE-B818-70445379CDF1"),
                ClienteId = Guid.Parse("F486016F-9D68-4BD1-977C-1E0990707806"),
                Agencia = 1,
                Numero = 2,
                Saldo = 0m
            });
        }
    }
}