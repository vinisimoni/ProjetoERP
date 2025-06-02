using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoCadastro.Domain;
using ProjetoERP.Domain;

namespace ProjetoCadastro.Data.Mappings
{
    public class MaterialMap : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            builder.ToTable("Materiais");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                    .ValueGeneratedOnAdd()
                    .UseIdentityColumn();

            builder.Property(d => d.Descricao)
                    .IsRequired()
                    .HasColumnName("Descricao")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100);

            builder.Property(d => d.Referencia)
                    .IsRequired(false)
                    .HasColumnName("Referencia")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100);

            builder.Property(d => d.Unidade)
                    .IsRequired()
                    .HasColumnName("Unidade")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(10);

            builder.Property(x => x.Situacao)
                    .IsRequired()
                    .HasColumnName("Situacao")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(10);

            builder.Property(x => x.ControleEstoque)
                    .IsRequired()
                    .HasColumnName("ControleEstoque")
                    .HasColumnType("BIT");

            builder.Property(x => x.EstoqueAtual)
                    .IsRequired()
                    .HasColumnName("EstoqueAtual")
                    .HasColumnType("DECIMAL(15,5)");

            builder.Property(x => x.ValorVenda)
                    .IsRequired()
                    .HasColumnName("ValorVenda")
                    .HasColumnType("DECIMAL(15,2)");


        }
    }
}
