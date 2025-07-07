using ProjetoERP.Domain.ValueObject;

namespace ProjetoERP.Domain
{
    public class Fornecedor
    {
        public Fornecedor()
        {
            Dados = new DadosCadastrais();
            Endereco = new Endereco();
        }

        public int Id { get; set; }
        public DadosCadastrais Dados { get; set; }
        public Endereco Endereco { get; set; }
        public string Situacao { get; set; }
    }
}
