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
        }
    }
}