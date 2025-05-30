using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoCadastro.Domain;

namespace ProjetoCadastro.Data.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                    .ValueGeneratedOnAdd()
                    .UseIdentityColumn();

            builder.Property(d => d.RazaoSocial)
                    .IsRequired()
                    .HasColumnName("RazaoSocial")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100);

            builder.Property(d => d.NomeFantasia)
                    .IsRequired(false)
                    .HasColumnName("NomeFantasia")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100);

            builder.Property(x => x.TipoPessoa)
                    .IsRequired()
                    .HasColumnName("TipoPessoa")
                    .HasColumnType("INT");

            builder.Property(x => x.CpfCnpj)
                    .IsRequired()
                    .HasColumnName("CpfCnpj")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(14);
         
            builder.Property(x => x.Endereco)
                    .IsRequired()
                    .HasColumnName("Endereco")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100);

            builder.Property(x => x.Bairro)
                    .IsRequired()
                    .HasColumnName("Bairro")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100);

            builder.Property(x => x.Cidade)
                    .IsRequired()
                    .HasColumnName("Cidade")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100);

            builder.Property(x => x.Estado)
                    .IsRequired()
                    .HasColumnName("Estado")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(2);

            builder.Property(x => x.Cep)
                    .IsRequired()
                    .HasColumnName("Cep")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(8);
            

            builder.Property(x => x.UtilizarMesmoEnderecoParaEntrega)
                    .IsRequired()
                    .HasColumnName("UtilizarMesmoEnderecoParaEntrega")
                    .HasColumnType("BIT");


            builder.Property(x => x.EnderecoEntrega)
                    .IsRequired()
                    .HasColumnName("EnderecoEntrega")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100);

            builder.Property(x => x.BairroEntrega)
                    .IsRequired()
                    .HasColumnName("BairroEntrega")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100);

            builder.Property(x => x.CidadeEntrega)
                    .IsRequired()
                    .HasColumnName("CidadeEntrega")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100);

            builder.Property(x => x.EstadoEntrega)
                    .IsRequired()
                    .HasColumnName("EstadoEntrega")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(2);

            builder.Property(x => x.CepEntrega)
                    .IsRequired()
                    .HasColumnName("CepEntrega")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(8);           

            builder.Property(x => x.Situacao)
                    .IsRequired()
                    .HasColumnName("Situacao")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(10);
        }
    }
}
