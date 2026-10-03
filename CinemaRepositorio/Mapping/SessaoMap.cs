using CinemaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaRepositorio.Mapping
{
    public class SessaoMap : IEntityTypeConfiguration<Sessao>
    {
        public void Configure(EntityTypeBuilder<Sessao> builder)
        {
            builder.ToTable("Sessao");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Data);
            builder.HasOne(x => x.Sala);
            builder.Property(x => x.Preco);
            
        }
    }
}