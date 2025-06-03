using ProjetoERP.Domain.Enums;

namespace ProjetoERP.Domain
{
    public class MovimentacaoEstoque
    {
        public int Id { get; set; }
        public int IdMaterial { get; set; }
        public string TipoMovimentacao { get; set; }
        public string Descricao { get; set; }
        public EOrigemMovMaterial OrigemMovimentacao { get; set; }
        public int? IdOrigemMovimentacao { get; set; }
        public decimal Quantidade { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public Material Materiais { get; set; }
    }
}
