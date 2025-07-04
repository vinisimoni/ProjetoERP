namespace ProjetoERP.Domain
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool AVista { get; set; }
        public int MaxParcelas { get; set; }
        public decimal TaxaAdministradora { get; set; }
        public int DiasRecebimento { get; set; }
        public bool AtualizarVencimentos { get; set; }
        public int IdConta { get; set; }
        public bool PermiteVenda { get; set; }
        public bool PermiteRecebimento { get; set; }
        public bool PermiteCompra { get; set; }
        public bool PermitePagamento { get; set; }
        public string Situacao { get; set; }

        public Conta Conta { get; set; }
        public virtual ICollection<FormaPagamentoParcela> Parcelas { get; set; }
    }
}
