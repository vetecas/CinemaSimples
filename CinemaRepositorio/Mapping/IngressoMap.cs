using CinemaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaRepositorio.Mapping
{
    public class IngressoMap : IEntityTypeConfiguration<Ingresso>
    {
        public void Configure(EntityTypeBuilder<Ingresso> builder)
        {
            builder.ToTable("Ingresso");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DataCompra);
            builder.HasOne(x => x.Secao);
            builder.Property(x => x.ValorTotal);
            builder.Property(x => x.FormaPagamento)
                .HasMaxLength(100);
            builder.HasMany(x => x.IngressoItens)
                .WithOne(x => x.Ingresso)
                .OnDelete(DeleteBehavior.Cascade);
     
        }

    }

    public class IngressoItemMap : IEntityTypeConfiguration<IngressoItem>
    {
        public void Configure(EntityTypeBuilder<IngressoItem> builder)
        {
            builder.ToTable("IngressoItem");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Assento);
            builder.Property(x => x.Fileira);
            builder.Property(x => x.MeiaEntrada);
            builder.HasOne(x => x.Ingresso)
                .WithMany(x=> x.IngressoItens)
                .OnDelete(DeleteBehavior.Cascade);

        }

    }
}