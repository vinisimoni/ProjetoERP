using ProjetoCadastro.Domain;
using ProjetoCadastro.Domain.Enums;
using ProjetoCadastro.Domain.ValueObject;

namespace ProjetoCadastro.ViewModels
{
    public class ClienteViewModel
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

        public Cliente ToEntity()
        {
            return new Cliente(
                this.Id,
                new DadosCadastrais(this.RazaoSocial, this.NomeFantasia, this.TipoPessoa, this.CpfCnpj),
                new Endereco(this.Endereco, this.Bairro, this.Cidade, this.Estado, this.Cep),
                this.UtilizarMesmoEnderecoParaEntrega,
                new Endereco(this.EnderecoEntrega, this.BairroEntrega, this.CidadeEntrega, this.EstadoEntrega, this.CepEntrega)
            );
        }
    }
}
