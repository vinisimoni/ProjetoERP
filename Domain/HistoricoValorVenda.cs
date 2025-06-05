namespace ProjetoERP.Domain
{
    public class HistoricoValorVenda
    {
        public int Id { get; set; }
        public int IdMaterial { get; set; }
        public DateTime DataLancamento { get; set; }
        public decimal ValorAnterior { get; set; }
        public decimal ValorNovo { get; set; }
        public Material Materiais { get; set; }
    }
}
