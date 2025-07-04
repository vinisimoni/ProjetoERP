namespace ProjetoERP.Domain
{
    public class FormaPagamentoParcela
    {
        public int Id { get; set; }
        public int IdFormaPagamento { get; set; }
        public int NrParcela { get; set; }
        public int Dias { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
    }
}
