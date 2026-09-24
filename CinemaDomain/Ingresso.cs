namespace CinemaDomain
{
    public class Ingresso : BaseEntity
    {
        public string Documento { get; set; }

        public Sessao Secao { get; set; }

        public DateTime DataCompra { get; set; }
 

        public string FormaPagamento { get; set; }

        public List<IngressoItem> IngressoItens { get; set; }

        public decimal ValorTotal { get; set; }
    }
}