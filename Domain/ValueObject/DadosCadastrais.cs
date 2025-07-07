using ProjetoCadastro.Domain.Enums;

namespace ProjetoERP.Domain.ValueObject
{
    public class DadosCadastrais
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public ETipoPessoa TipoPessoa { get; set; }
        public string CpfCnpj { get; set; }
    }
}
