using ProjetoCadastro.Domain.ValueObject;

namespace ProjetoCadastro.Domain
{
    public class Cliente
    {
        public Cliente()
        {
            
        }
        public Cliente(int id, DadosCadastrais dados, Endereco endereco, bool utilizarMesmoEnderecoParaEntrega, Endereco enderecoEntrega)
        {
            Id = id;
            Dados = dados;
            Endereco = endereco;
            UtilizarMesmoEnderecoParaEntrega = utilizarMesmoEnderecoParaEntrega;
            EnderecoEntrega = enderecoEntrega;
        }

        public int Id { get; set; }
        public DadosCadastrais Dados { get; set; }
        public Endereco Endereco { get; set; }
        public bool UtilizarMesmoEnderecoParaEntrega { get; set; }
        public Endereco EnderecoEntrega { get; set; }
    }
}
