using ContaCorrente.Business.Models.Clientes;
using ContaCorrente.Infra.EF.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.Infra.EF.Data.Mappings
{
    internal class ClienteConfig : DbEntityConfiguration<Cliente>
    {
        public override void Configure(EntityTypeBuilder<Cliente> entity)
        {
            entity.ToTable("Clientes");
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Nome).IsRequired().HasMaxLength(100);
            entity.Property(c => c.Documento).IsRequired().HasMaxLength(14);
            entity.HasData(new Cliente[] {
                new Cliente(Guid.Parse("BC948E10-BFED-4F7A-B26A-ACFE6E2D51B1"), "Cliente 1", "99999999999"),
                new Cliente(Guid.Parse("F486016F-9D68-4BD1-977C-1E0990707806"), "Cliente 2", "11111111111")
            });
        }
    }
}