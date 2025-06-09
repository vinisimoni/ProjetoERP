using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjetoERP.Domain;

namespace ProjetoERP.Data.Mappings
{
    public class FormaPagamentoMap : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.ToTable("FormasPagamento");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .ValueGeneratedOnAdd()
                   .UseIdentityColumn();

            builder.Property(x => x.Descricao)
                   .IsRequired()
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(100);

            builder.Property(x => x.AVista)
                   .IsRequired();

            builder.Property(x => x.MaxParcelas)
                   .IsRequired();

            builder.Property(x => x.TaxaAdministradora)
                   .HasColumnType("DECIMAL(10,2)")
                   .IsRequired();

            builder.Property(x => x.DiasRecebimento)
                   .IsRequired();

            builder.Property(x => x.AtualizarVencimentos)
                   .IsRequired();

            builder.Property(x => x.IdConta)
                   .IsRequired();

            builder.Property(x => x.PermiteVenda).IsRequired();
            builder.Property(x => x.PermiteRecebimento).IsRequired();
            builder.Property(x => x.PermiteCompra).IsRequired();
            builder.Property(x => x.PermitePagamento).IsRequired();

            builder.Property(x => x.Situacao)
               .IsRequired()
               .HasColumnType("VARCHAR")
               .HasMaxLength(10);

            // Relacionamento com Conta
            builder.HasOne(x => x.Conta)
                   .WithMany() // ou .WithMany(c => c.FormasPagamento) se for bidirecional
                   .HasForeignKey(x => x.IdConta)
                   .OnDelete(DeleteBehavior.Restrict); // ou .Cascade, conforme a regra de negócio
        }
    }
}
