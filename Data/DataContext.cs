using Microsoft.EntityFrameworkCore;
using ProjetoCadastro.Domain;
using ProjetoERP.Domain;

namespace ProjetoCadastro.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"User ID=sa;Database=ProjetoERP;Password =sql@125632;Data Source=VINICIUS-NOTE\SQLEXPRESS;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Material> Materiais { get; set; }
        public DbSet<MovimentacaoEstoque> MovimentacaoEstoque { get; set; }
        public DbSet<HistoricoValorVenda> HistoricoValorVenda { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<FormaPagamento> FormasPagamento { get; set; }
    }
}
