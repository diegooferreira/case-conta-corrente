using ContaCorrente.Business.Models.Clientes;
using ContaCorrente.Business.Models.Contas;
using ContaCorrente.Business.Models.Transacoes;
using ContaCorrente.Infra.EF.Data.Extensions;
using ContaCorrente.Infra.EF.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ContaCorrente.Infra.EF.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Configuration.ProxyCreationEnabled = false;
            //Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer($"Server=localhost, 1433;Initial Catalog=CcDb;User ID=sa;Password=xp123!@#");
            }
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Transacao> Transacoes { get; set; }
        public DbSet<Conta> Contas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p
                    .HasColumnType("varchar")
                    .HasMaxLength(100));

            modelBuilder.Configurations.Add(new FornecedorConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            modelBuilder.Configurations.Add(new ProdutoConfig());*/

            //modelBuilder.

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
            {
                property.SetColumnType("varchar");
            }

            //modelBuilder.RemovePluralizingTableNameConvention();

            modelBuilder.AddConfiguration(new ClienteConfig());
            modelBuilder.AddConfiguration(new ContaConfig());
            modelBuilder.AddConfiguration(new TransacaoConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
