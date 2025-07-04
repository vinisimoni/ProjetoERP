using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjetoERP.Domain;

namespace ProjetoERP.Data.Mappings
{
    public class FormaPagamentoParcelaMap : IEntityTypeConfiguration<FormaPagamentoParcela>
    {
        public void Configure(EntityTypeBuilder<FormaPagamentoParcela> builder)
        {
            builder.ToTable("FormasPagamentoParcelas");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .ValueGeneratedOnAdd()
                   .UseIdentityColumn();

            builder.Property(x => x.IdFormaPagamento).IsRequired();
            builder.Property(x => x.NrParcela).IsRequired();
            builder.Property(x => x.Dias).IsRequired();

            builder.HasOne(fpp => fpp.FormaPagamento)
               .WithMany(fp => fp.Parcelas)
               .HasForeignKey(fpp => fpp.IdFormaPagamento)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
