using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoERP.Domain;

namespace ProjetoERP.Data.Mappings
{
    public class MovimentacaoEstoqueMap : IEntityTypeConfiguration<MovimentacaoEstoque>
    {
        public void Configure(EntityTypeBuilder<MovimentacaoEstoque> builder)
        {
            builder.ToTable("MovimentacaoEstoque");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                    .ValueGeneratedOnAdd()
                    .UseIdentityColumn();

            builder.Property(d => d.IdMaterial)
                    .IsRequired()
                    .HasColumnName("IdMaterial")
                    .HasColumnType("INT");

            builder.Property(d => d.TipoMovimentacao)
                    .IsRequired()
                    .HasColumnName("TipoMovimentacao")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(10);

            builder.Property(d => d.Descricao)
                    .IsRequired(false)
                    .HasColumnName("Descricao")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100);

            builder.Property(d => d.OrigemMovimentacao)
                    .IsRequired()
                    .HasColumnName("OrigemMovimentacao")
                    .HasColumnType("INT");

            builder.Property(d => d.IdOrigemMovimentacao)
                    .IsRequired(false)
                    .HasColumnName("IdOrigemMovimentacao")
                    .HasColumnType("INT");

            builder.Property(x => x.Quantidade)
                    .IsRequired()
                    .HasColumnName("Quantidade")
                    .HasColumnType("DECIMAL(15,5)");

            builder.Property(x => x.DataMovimentacao)
                    .IsRequired()
                    .HasColumnName("DataMovimentacao")
                    .HasColumnType("DATETIME2");

            builder.HasOne(m => m.Materiais)
                   .WithMany() 
                   .HasForeignKey(m => m.IdMaterial)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
