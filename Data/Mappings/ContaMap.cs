using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjetoERP.Domain;

namespace ProjetoERP.Data.Mappings
{
    public class ContaMap : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.ToTable("Contas");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                    .ValueGeneratedOnAdd()
                    .UseIdentityColumn();

            builder.Property(d => d.Descricao)
                    .IsRequired()
                    .HasColumnName("Descricao")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100);
        }
    }
}
