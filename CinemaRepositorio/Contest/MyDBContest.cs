using CinemaDomain;
using CinemaRepositorio.Mapping;
using Microsoft.EntityFrameworkCore;

namespace CinemaRepositorio.Contest
{
    internal class MyDBContest
    {
        public class MyDBCoutext : DbContext
        {
            public DbSet<Genero> Genero { get; set; }
            public DbSet<Filme> Filme { get; set; }
            public DbSet<Sala> Sala { get; set; }
            public DbSet<Sessao> Sessao { get; set; }
            public DbSet<Ingresso> Ingresso { get; set; }
            public DbSet<IngressoItem> IngressoItem { get; set; }


            public MyDBCoutext()
            {
                Database.EnsureCreated(); // Verifica se o banco existe, se não tiver ele cria
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<Genero>(new GeneroMap().Configure);
                modelBuilder.Entity<Filme>(new FilmeMap().Configure);
                modelBuilder.Entity<Sala>(new SalaMap().Configure);
                modelBuilder.Entity<Sessao>(new SessaoMap().Configure);
                modelBuilder.Entity<Ingresso>(new IngressoMap().Configure);
                modelBuilder.Entity<IngressoItem>(new IngressoItemMap().Configure);
            }
        }
    }
}
