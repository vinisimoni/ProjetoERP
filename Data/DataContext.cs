using Microsoft.EntityFrameworkCore;
using ProjetoCadastro.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
