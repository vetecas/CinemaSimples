using CinemaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaRepositorio.Mapping
{
    public class GeneroMap : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.ToTable("Melancia");
            //builder.ToTable("Genero");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome)
                .HasColumnName("NomeDoGenero")
                .IsRequired(true)
                .HasMaxLength(50);
        }
    }
}
