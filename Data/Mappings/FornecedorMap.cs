using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjetoCadastro.Domain;
using ProjetoERP.Domain;

namespace ProjetoERP.Data.Mappings
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedores");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                    .ValueGeneratedOnAdd()
                    .UseIdentityColumn();

            builder.OwnsOne(c => c.Dados, dados =>
            {
                dados.Property(d => d.RazaoSocial)
                    .IsRequired()
                    .HasColumnName("RazaoSocial")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100);

                dados.Property(d => d.NomeFantasia)
                    .IsRequired(false)
                    .HasColumnName("NomeFantasia")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100);

                dados.Property(x => x.TipoPessoa)
                    .IsRequired()
                    .HasColumnName("TipoPessoa")
                    .HasColumnType("INT");

                dados.Property(x => x.CpfCnpj)
                    .IsRequired()
                    .HasColumnName("CpfCnpj")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(14);
            });

            builder.OwnsOne(c => c.Endereco, endereco =>
            {
                endereco.Property(e => e.Rua)
                    .IsRequired(false)
                    .HasColumnName("Endereco")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100);

                endereco.Property(e => e.Bairro)
                    .IsRequired(false)
                    .HasColumnName("Bairro")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100);

                endereco.Property(e => e.Cidade)
                    .IsRequired(false)
                    .HasColumnName("Cidade")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100);

                endereco.Property(e => e.Estado)
                    .IsRequired(false)
                    .HasColumnName("Estado")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(2);

                endereco.Property(e => e.Cep)
                    .IsRequired(false)
                    .HasColumnName("Cep")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(8);
            });

            builder.Property(x => x.Situacao)
                    .IsRequired()
                    .HasColumnName("Situacao")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(10);
        }
    }
}
