using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjetoERP.Domain;

namespace ProjetoERP.Data.Mappings
{
    public class HistoricoValorVendaMap : IEntityTypeConfiguration<HistoricoValorVenda>
    {
        public void Configure(EntityTypeBuilder<HistoricoValorVenda> builder)
        {
            builder.ToTable("HistoricoValorVenda");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                    .ValueGeneratedOnAdd()
                    .UseIdentityColumn();

            builder.Property(d => d.IdMaterial)
                    .IsRequired()
                    .HasColumnName("IdMaterial")
                    .HasColumnType("INT");

            builder.Property(x => x.DataLancamento)
                    .IsRequired()
                    .HasColumnName("DataLancamento")
                    .HasColumnType("DATETIME2");

            builder.Property(x => x.ValorAnterior)
                    .IsRequired()
                    .HasColumnName("ValorAnterior")
                    .HasColumnType("DECIMAL(15,2)");

            builder.Property(x => x.ValorNovo)
                    .IsRequired()
                    .HasColumnName("ValorNovo")
                    .HasColumnType("DECIMAL(15,2)");

            builder.HasOne(m => m.Materiais)
                   .WithMany()
                   .HasForeignKey(m => m.IdMaterial)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
