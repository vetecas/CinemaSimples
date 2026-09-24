namespace CinemaDomain
{
    public class Secao : BaseEntity
    {
        public Filme Filme { get; set; }

        public Sala Sala { get; set; }

        public int Data { get; set; }

        public decimal Preco { get; set; }
    }
}