using ProjetoCadastro.Domain;
using ProjetoCadastro.Repositories;

namespace ProjetoERP.Services
{
    public class ClienteService
    {
        private readonly ClienteRepository _repository;

        public ClienteService()
        {
            _repository = new ClienteRepository();
        }

        public void Incluir(Cliente cliente)
        {
            _repository.Incluir(cliente);
        }

        public void Atualizar(Cliente cliente)
        {
            _repository.Atualizar(cliente);
        }

        public IEnumerable<object> CarregarClientesFiltro(string situacao, string tipoPessoa,
            string filtroSelecionado, string filtro)
        {
            return _repository.CarregarClientesFiltro(situacao, tipoPessoa, filtroSelecionado, filtro);
        }

        public Cliente ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public void Excluir(int id)
        {
            _repository.Excluir(id);
        }

        public void DetachedCliente(Cliente cliente)
        {
            _repository.DetachedCliente(cliente);
        }

    }
}
