using ProjetoCadastro.Domain.Enums;

namespace ProjetoCadastro.Domain.ValueObject
{
    public class DadosCadastrais
    {
        public DadosCadastrais(string razaoSocial, string nomeFantasia, ETipoPessoa tipoPessoa, string cpfCnpj)
        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            TipoPessoa = tipoPessoa;
            CpfCnpj = cpfCnpj;
        }

        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public ETipoPessoa TipoPessoa { get; set; }
        public string CpfCnpj { get; set; }
    }
}
