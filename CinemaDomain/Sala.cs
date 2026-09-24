namespace CinemaDomain
{
    public class Sala : BaseEntity
    {
        public int Capacidade { get; set; }

        public int Numero { get; set; }

        public string Fileiras { get; set; }

        public int Assentos { get; set; }
    }
}