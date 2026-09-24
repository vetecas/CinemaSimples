namespace CinemaDomain
{
    public class Sessao : BaseEntity
    {
        public Filme Filme { get; set; }

        public Sala Sala { get; set; }

        public System.DateTime Data { get; set; }

        public decimal Preco { get; set; }
    }
}