namespace CinemaDomain
{
    public class IngressoItem : BaseEntity
    {
        public int Assento { get; set; }

        public string Fileira { get; set; }

        public Ingresso Ingresso { get; set; }

        public bool MeiaEntrada { get; set; }
    }
}