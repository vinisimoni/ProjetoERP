namespace ProjetoCadastro.Domain.ValueObject
{
    public class Endereco
    {
        public Endereco(string rua, string bairro, string cidade, string estado, string cep)
        {
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }

        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
    }
}
