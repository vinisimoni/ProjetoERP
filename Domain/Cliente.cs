using ProjetoCadastro.Domain.Enums;

namespace ProjetoCadastro.Domain
{
    public class Cliente
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public ETipoPessoa TipoPessoa { get; set; }
        public string CpfCnpj { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public bool UtilizarMesmoEnderecoParaEntrega { get; set; }
        public string EnderecoEntrega { get; set; }
        public string BairroEntrega { get; set; }
        public string CidadeEntrega { get; set; }
        public string EstadoEntrega { get; set; }
        public string CepEntrega { get; set; }
        public string Situacao { get; set; }
    }
}
